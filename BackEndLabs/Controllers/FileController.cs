using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Drawing;
using BackEndLabs.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using BackEndLabs.Models;
using Microsoft.Extensions.Options;
using BackEndLabs.Extensions;
using System.ComponentModel;
using System.IO.Compression;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using Image = System.Drawing.Image;
using BackEndLabs.Enum;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Data;
using System.Linq;

namespace BackEndLabs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController(ApplicationDbContext context, IOptions<FileFormatter> fileOptions) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;
        private readonly FileFormatter _fileOptions = fileOptions.Value;



        [HttpPost("load")]
        //[Authorize(Policy = nameof(PermissionsNames.update_user))]
        public async Task<IActionResult> LoadFile(IFormFile file)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            string userName = _context.Users
                        .AsNoTracking()
                        .FirstOrDefault(u => u.Id == userId)!
                        .UserName;


            using (var stream = file.OpenReadStream())
            {
                try
                {
                    using var originalImage = Image.FromStream(stream);

                    int originalWidth = originalImage.Width;
                    int originalHeight = originalImage.Height;
                    long originalSizeInBytes = file.Length;


                    if (_fileOptions.Height < originalHeight || _fileOptions.Width < originalWidth)
                    {
                        return BadRequest("Не подходящее расширение файла");
                    }
                    if(_fileOptions.Size < originalSizeInBytes)
                    {
                        return BadRequest("Слишком большой файл");
                    }


                    int newWidth = 128;
                    int newHeight = 128;

                    Bitmap avatarImage = new(newWidth, newHeight);
                    Graphics g = Graphics.FromImage(avatarImage);
                    g.DrawImage(originalImage, 0, 0, newWidth, newHeight);



                    string fileFormat = originalImage.RawFormat.ToString();
                    string fileSize = $"{originalWidth}x{originalHeight}";

                    string fileName = $"{userName}_{userId}.{fileFormat}";
                    string avatarFileName = $"{userName}_{userId}_avatar.{fileFormat}";


                    string destinationFile = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Images\";

                    string serverPathToSaveOriginalFile = destinationFile + fileName;
                    string serverPathToSaveAvatarFile = destinationFile + avatarFileName;


                    string fileNameTemplate = $"{userName}_{userId}.";


                    List<string> fileNameToDelete = Directory.GetFiles(destinationFile)
                        .Where(f => f.StartsWith(fileNameTemplate))
                        .ToList();

                    avatarImage.Save(serverPathToSaveAvatarFile);
                    originalImage.Save(serverPathToSaveOriginalFile);
                    fileNameToDelete.ForEach(f => System.IO.File.Delete(destinationFile + f));


                    var transaction = await _context.Database.BeginTransactionAsync();
                    try
                    {
                        await _context.Files
                        .Where(f => f.Created_By == userId)
                            .ExecuteDeleteAsync();


                        Models.File userFile = new()
                        {
                            Created_By = userId,
                            Format = fileFormat,
                            Link = serverPathToSaveOriginalFile,
                            Name = fileName,
                            Size = fileSize
                        };

                        await _context.Files.AddAsync(userFile);
                        await _context.SaveChangesAsync();
                        await transaction.CommitAsync();
                        return Ok();

                    }
                    catch(Exception ex)
                    {
                        await transaction.RollbackAsync();
                        Console.WriteLine(ex.Message);
                        return BadRequest("Не удалось сохранить фотографию");
                    }
                    

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("ArgumentException: NE TOT FORMAT!!!");
                    Console.WriteLine(ex.Message);
                }
            }
            return BadRequest();
        }



        [HttpGet("download")]
        [Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task DownLoadFile()
        {

            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            Models.File? file = await _context.Files
                .AsNoTracking()
                .FirstOrDefaultAsync(f => f.Created_By == userId);

            if (file == null)
            {
                Response.StatusCode = 204;
            }
            else
            {
                Response.Headers.ContentDisposition = "attachment; filename=avatar.jpg";
                await Response.SendFileAsync(file.Link);
            }

            
        }



        [HttpGet("getUserFile")]
        public async Task GetFile()
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);

            string userName = _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.Id == userId)!
                .UserName;


            string filePath = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Images\";

            string[] files = Directory.GetFiles(filePath);
            string? file = files
                .FirstOrDefault(f => f.Contains("avatar") && f.Contains(userName));    


            if (System.IO.File.Exists(file))
            {
                Response.ContentType = "image/jpeg";
                await Response.SendFileAsync(file);
            }
            else
            {
                Response.StatusCode = 204;
            }
        }







        [HttpGet("getFilesArchive")]
        //[Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task GetArchiveFile()
        {
            //int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            string pathToRoot = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Images\";
            string archiveName = "files.zip";
            string excelName = "excelTable.xlsx";

            string archiveFullName = pathToRoot + archiveName;
            string excelFileFullName = pathToRoot + excelName;


            var files = Directory.GetFiles(pathToRoot);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(excelFileFullName))
            {
                var worksheet = package.Workbook.Worksheets.Add("Лист1");

                int rowIndex = 1; 

                foreach (var file in files)
                {
                    int userId = 0;
                    string userName = "";
                    string[] nameArray = file.Split("_");
                    if (file.Contains("avatar"))
                    {
                        userId = int.Parse(nameArray[^2]);
                        userName = nameArray[0].Split("\\")[^1];
                    }
                    else
                    {
                        userId = int.Parse(nameArray[nameArray.Length - 1].Split(".")[0]);
                        userName = nameArray[0].Split("\\")[^1];
                    }

                    var uploadDate = _context.Files
                        .AsNoTracking()
                        .Where(f => f.Created_By == userId)
                        .Select(f => f.Created_At)
                        .FirstOrDefault();


                    worksheet.Cells[rowIndex, 1].Value = userId;
                    worksheet.Cells[rowIndex, 3].Value = userName;
                    worksheet.Cells[rowIndex, 5].Value = uploadDate.ToString();
                    worksheet.Cells[rowIndex, 7].Value = file;
                    worksheet.Cells[rowIndex, 9].Value = file;

                    rowIndex++;
                }
                package.Save();
            }


            var updatedFiles = Directory.GetFiles(pathToRoot);

            using (ZipArchive archive = ZipFile.Open(archiveFullName, ZipArchiveMode.Create))
            {
                foreach (var file in updatedFiles)
                {
                    string[] filePath = file.Split("\\");
                    string fileName = filePath[^1];
                    archive.CreateEntryFromFile(file, fileName);
                }
            }

            Response.Headers.ContentDisposition = "attachment; filename=archive.zip";
            await Response.SendFileAsync(archiveFullName);
            System.IO.File.Delete(archiveFullName);
            System.IO.File.Delete(excelFileFullName);
        }



        [HttpGet("getRolesFile")]
        //[Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task GetRolesFile()
        {
            string pathToRoot = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Excel\";
            string excelName = "excelRoles.xlsx";

            string excelFileFullName = pathToRoot + excelName;

            var roles = await _context.Roles.ToListAsync();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(excelFileFullName))
            {
                var worksheet = package.Workbook.Worksheets.Add("Roles");

                worksheet.Cells[1, 1].Value = "RoleId";
                worksheet.Cells[1, 2].Value = "RoleName";
                worksheet.Cells[1, 3].Value = "RoleDescription";
                worksheet.Cells[1, 4].Value = "RoleCode";

                int rowIndex = 2;

                foreach(var role in roles) 
                { 
                    worksheet.Cells[rowIndex, 1].Value = role.Id;
                    worksheet.Cells[rowIndex, 2].Value = role.Name;
                    worksheet.Cells[rowIndex, 3].Value = role.Description;
                    worksheet.Cells[rowIndex, 4].Value = role.Code;
                    rowIndex++;
                }

                package.Save();
            }


            Response.Headers.ContentDisposition = "attachment; filename=roles.xlsx";
            await Response.SendFileAsync(excelFileFullName);
            System.IO.File.Delete(excelFileFullName);
        }



        [HttpGet("getPermissionsFile")]
        //[Authorize(Policy = nameof(PermissionsNames.read_user))]
        public async Task GetPermissionsFile()
        {
            string pathToRoot = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Excel\";
            string excelName = "excelPermissions.xlsx";

            string excelFileFullName = pathToRoot + excelName;

            var permissions = await _context.Permissions.ToListAsync();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(excelFileFullName))
            {
                var worksheet = package.Workbook.Worksheets.Add("Roles");

                worksheet.Cells[1, 1].Value = "PermissionId";
                worksheet.Cells[1, 2].Value = "PermissionName";
                worksheet.Cells[1, 3].Value = "PermissionDescription";
                worksheet.Cells[1, 4].Value = "PermissionCode";

                int rowIndex = 2;

                foreach (var permission in permissions)
                {
                    worksheet.Cells[rowIndex, 1].Value = permission.Id;
                    worksheet.Cells[rowIndex, 2].Value = permission.Name;
                    worksheet.Cells[rowIndex, 3].Value = permission.Description;
                    worksheet.Cells[rowIndex, 4].Value = permission.Code;
                    rowIndex++;
                }

                package.Save();
            }


            Response.Headers.ContentDisposition = "attachment; filename=permissions.xlsx";
            await Response.SendFileAsync(excelFileFullName);
            System.IO.File.Delete(excelFileFullName);
        }






        [HttpPost("importRolesExcelFile")]
        [Authorize]
        public async Task<IActionResult> ImportRolesExcelFile(IFormFile file)
        {
            int userId = int.Parse(User.FindFirst("UserIdentity")!.Value);


            string pathToRoot = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Excel\";
            string excelName = "roles.xlsx";
            string pathToExcelFile = pathToRoot + excelName;

            
            using (Stream fileStream = new FileStream(pathToExcelFile, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }


            bool saveIfHasExceptions = false;
            bool exitIfHasExceptions = false;
            int exceptionsCount = 0;

            StringBuilder loadingReport = new();
            List<Role> rolesFromDb = await _context.Roles.ToListAsync();



            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(pathToExcelFile))
            {
                bool canOverride = true;

                ExcelWorksheet worksheet = package.Workbook.Worksheets["Roles"];

                for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                {
                    try // если не удастся создать объект car
                    {
                        int id = int.Parse(worksheet.Cells[i, 1].Value.ToString());
                        Role role = new()
                        {
                            Id = id,
                            Name = worksheet.Cells[i, 2].Value.ToString()!,
                            Description = (string?)worksheet.Cells[i, 3].Value == null? null: worksheet.Cells[i, 3].Value.ToString(),
                            Code = worksheet.Cells[i, 4].Value.ToString()!,
                            Created_At = id != 0 ? rolesFromDb.Single(r => r.Id == id).Created_At : DateTime.UtcNow,
                            Created_By = id != 0 ? rolesFromDb.Single(r => r.Id == id).Created_By : userId 
                        };


                        if (canOverride)
                        {
                            //РЕЖИМ ПЕРЕЗАПИСИ
                            if (rolesFromDb.Any(c => c.Id == role.Id))
                            {
                                var carFromDb = rolesFromDb.First(c => c.Id == role.Id);
                                _context.Entry(carFromDb).State = EntityState.Deleted;
                                await _context.AddAsync(role);
                                loadingReport.AppendLine($"Запись № {i} успешно обновила запись с идентификатором № {role.Id}");
                            }
                            else
                            {
                                await _context.AddAsync(role);
                                loadingReport.AppendLine($"Запись № {i} успешно добавлена с идентификатором  № {role.Id}");
                            }
                        }
                        else
                        {
                            //РЕЖИМ ДОБАВЛЕНИЯ
                            if (rolesFromDb.Any(c => c.Id == role.Id))
                            {
                                role.Id = 0;
                            }

                            await _context.AddAsync(role);
                            loadingReport.AppendLine($"Запись № {i} успешно добавлена с идентификатором  № {role.Id}");
                        }

                        _context.ChangeTracker.DetectChanges();

                    }
                    catch (Exception ex)
                    {
                        loadingReport.AppendLine($"Запись №{i} не удалось добавить/обновить. Неизвестная ошибка.");
                        Console.WriteLine("Simple Exception: " + ex.Message);
                        exceptionsCount++;

                        if (exitIfHasExceptions)
                            return BadRequest("Ошибка при чтении данных! Проверьте целостность и уникальность данных. \n" +
                                loadingReport.ToString());
                    }
                }
            }

            if ((exceptionsCount == 0) || saveIfHasExceptions)
            {
                await _context.SaveChangesAsync();
                string report = loadingReport.ToString();
                return Ok(report);
            }
            else
            {
                return BadRequest("Данные не были сохранены.");
            }
        }
    }
}
