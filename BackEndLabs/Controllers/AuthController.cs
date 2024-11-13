using BackEndLabs.Contracts.Request;
using BackEndLabs.Contracts.Response;
using BackEndLabs.Data;
using BackEndLabs.Enum;
using BackEndLabs.JWT;
using BackEndLabs.Models;
using BackEndLabs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(ApplicationDbContext context, JwtProvider jwtProvider,  
        TokenService tokenService, IOptions<JWTConfiguration> options) : ControllerBase
    {
        private readonly JwtProvider _jwtProvider = jwtProvider;
        private readonly ApplicationDbContext _context = context;
        private readonly TokenService _tokenService = tokenService;
        private readonly JWTConfiguration _jWTConfiguration = options.Value;



        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> AuthorizeUser([FromBody] LoginRequest loginRequest)
        {
            // validation
            
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == loginRequest.UserName);
            
            
            if (user == null || user.Password != loginRequest.Password)
            { 
                return BadRequest("Неверный логин или пароль");
            }
            
            string? token = _jwtProvider
                .CreateNewToken(user.Id);
            
            if (token != null)
            {
                await _tokenService
                    .CreateAndSaveTokenInDataBase(token, user.Id, _jWTConfiguration.ExpiresMinutes);

                Response.Cookies.Append("NeToken", token);
                return Ok();
            }

            return BadRequest("Слишком много токенов для одного пользователя! ");
        }



        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequest registerRequest)
        {
            // validation


            string[] date = registerRequest.Birthday.Split("-");
            
            DateOnly birthDay = new(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
            
            User user = Models.User.CreateUser(
                registerRequest.UserName, registerRequest.Email,
                birthDay, registerRequest.Password);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();


            UsersAndRoles usersAndRoles = new()
            {
                RoleId = 2,
                UserId = user.Id,
                Created_By = user.Id
            };

            
            await _context.UsersAndRoles.AddAsync(usersAndRoles);
            await _context.SaveChangesAsync();


            UserDTO userDTO = new()
            {
                UserName = user.UserName,
                Email = user.Email,
                BirthDate = user.BirthDay
            };

            return Created("", userDTO);
        }



        [HttpGet]
        [Route("me")]
        [Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task<IActionResult> GetInfoOfAuthorizedUser()
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
                return BadRequest();

            UserDTO userDTO = new()
            {
                BirthDate = user.BirthDay,
                Email = user.Email,
                UserName = user.UserName
            };
            return Ok(userDTO);
        }



        [HttpPost]
        [Route("out")]
        //[Authorize(Policy = nameof(PermissionsNames.update_user))]
        public async Task<IActionResult> OutUserRegistration()
        {
            string? token = Request.Cookies["NeToken"] ?? Request.Headers.Authorization.ToString().Replace("Bearer ", "");


            if (token != null)
            {
                await context.Tokens
                    .Where(t => t.Name == token)
                    .ExecuteDeleteAsync();
            }
            return Ok($"Пользователь с токеном {token} вышел из системы");
        }


        
        [HttpGet]
        [Route("tokens")]
        [Authorize(Policy = nameof(PermissionsNames.read_user))]
        public IActionResult GetRegistredUserTokens()
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            var tokens = _context.Tokens
                .AsNoTracking()
                .Where(t => t.UserId == userId)
                .Select(t => t.Name)
                .ToList();

            return Ok(tokens);
        }



        [HttpPost]
        [Route("out_all")]
        [Authorize(Policy = nameof(PermissionsNames.update_user))]
        public IActionResult UnlogUserTokens()
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            var tokens = _context.Tokens
                .Where(t => t.UserId == userId)
                .IgnoreQueryFilters()
                .ExecuteDeleteAsync();

            return Ok("Все токены были успешно удалены");
        }



        [HttpPost]
        [Route("changePassword")]
        [Authorize(Policy = nameof(PermissionsNames.update_user))]
        public async Task<IActionResult> ChangeUserPassword([FromBody] ChangePasswordRequest changePasswordRequest)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return BadRequest("Нет пользователя с таким Id");
            }

            if (user.Password == changePasswordRequest.oldPassword)
            {
                user.Password = changePasswordRequest.newPassword;
                await _context.SaveChangesAsync();
                return Ok("Пароль успешно изменен");
            }

            return BadRequest("Неверный пароль");
        }
    }
}
