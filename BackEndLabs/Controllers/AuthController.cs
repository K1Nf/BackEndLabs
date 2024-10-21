using BackEndLabs.Contracts;
using BackEndLabs.Contracts.Request;
using BackEndLabs.Data;
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
    public class AuthController(JwtProvider jwtProvider, ApplicationDbContext context, 
        TokenService tokenService, IOptions<JWTConfiguration> options) : ControllerBase
    {
        private readonly JwtProvider _jwtProvider = jwtProvider;
        private readonly ApplicationDbContext _context = context;
        private readonly TokenService _tokenService = tokenService;
        private readonly JWTConfiguration _jWTConfiguration = options.Value;

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> AuthorizeUser([FromForm] LoginRequest loginRequest)
        {
            // validation
           
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == loginRequest.UserName);


            if (user == null || user.Password != loginRequest.Password)
            { 
                return BadRequest("Печаль");
            }

            var token = _jwtProvider
                .CreateNewToken(user.Id);

            await _tokenService
                .CreateAndSaveTokenInDataBase(token, user.Id, _jWTConfiguration.ExpiresMinutes);

            return Ok(token);
        }



        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser([FromForm] RegisterRequest registerRequest)
        {
            // validation
            string[] date = registerRequest.Birthday.Split("-");

            DateOnly birthDay = new(int.Parse(date[1]), int.Parse(date[2]), int.Parse(date[0]));

            var user = Models.User.CreateUser(
                registerRequest.UserName, registerRequest.Email,
                birthDay, registerRequest.Password);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return Created("", new { Message = $"New user with {user.UserName} name was created!" });
        }



        [HttpGet]
        [Route("me")]
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> OutUserRegistration()
        {
            string token = Request.Headers
                .Authorization
                .ToString()
                .Replace("Bearer ", "");


            await context.Tokens
                .Where(t => t.Name == token)
                .ExecuteDeleteAsync();

            return Ok($"Пользователь с токеном {token} вышел из системы");
        }


        
        [HttpGet]
        [Route("tokens")]
        [Authorize(Policy = "Get-list-users")]
        
        public IActionResult GetRegistredUserTokens()
        {
            // 1. исходя из токена получить userId
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            // 2. исходя из userId получить все токены
            var tokens = _context.Tokens
                .AsNoTracking()
                .Where(t => t.UserId == userId)
                .Select(t => t.Name)
                .ToList();


            // 3. вернуть токены клиенту
            return Ok(tokens);
        }



        [HttpPost]
        [Route("out_all")]
        [Authorize]
        public IActionResult UnlogUserTokens()
        {
            // 1. исходя из токена получить userId
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            // 2. удалить из таблицы токены, у которых колонка userid = userid клиента
            var tokens = _context.Tokens
                .Where(t => t.UserId == userId)
                .ExecuteDeleteAsync();

            return Ok("Все токены были успешно удалены");
        }
    }
}
