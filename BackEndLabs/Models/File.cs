using BackEndLabs.Extensions;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackEndLabs.Models
{
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Format { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public int Created_By { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public int Deleted_By { get; set; }
        public DateTime Deleted_At { get; set; }

        [ForeignKey(nameof(Created_By))]
        public User? User { get; set; }



        public static void GetBackgroundReport(List<AnonymousMethodInfo> methods, 
            List<AnonymousEntitiesInfo> entities, 
            List<AnonymousUserInfo> usersInfo)
        {
            string pathToRoot = @"C:\Users\User\source\repos\BackEndLabs\BackEndLabs\Background\";
            string excelName = "jobreport.xlsx";
            string excelFileFullName = pathToRoot + excelName;


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(excelFileFullName))
            {
                
                var worksheet = package.Workbook.Worksheets["Report"] ?? package.Workbook.Worksheets.Add("Report");

                ExcelRange range = worksheet.Cells[1, 1, 1, 15];
                range.Style.Fill.SetBackground(color: OfficeOpenXml.Drawing.eThemeSchemeColor.Accent6);


                worksheet.Cells[1, 1].Value = "ActionName";
                worksheet.Cells[1, 2].Value = "CalledCount";
                worksheet.Cells[1, 3].Value = "LastAccess";
                                
                worksheet.Cells[1, 5].Value = "EntityId";
                worksheet.Cells[1, 6].Value = "EntityName";
                worksheet.Cells[1, 7].Value = "ChangesCount";
                worksheet.Cells[1, 8].Value = "LastUpdate";
                                
                worksheet.Cells[1, 10].Value = "UserId";
                worksheet.Cells[1, 11].Value = "RequestCount";
                worksheet.Cells[1, 12].Value = "AuthCount";
                worksheet.Cells[1, 13].Value = "Permissions";


                int methodRowIndex = 2;
                foreach (var method in methods)
                {
                    worksheet.Cells[methodRowIndex, 1].Value = method.Name;
                    worksheet.Cells[methodRowIndex, 2].Value = method.Count;
                    worksheet.Cells[methodRowIndex, 3].Value = method.LastAccess.ToString();
                    methodRowIndex++;
                }


                int entityRowIndex = 2;
                foreach (var entity in entities)
                {
                    worksheet.Cells[entityRowIndex, 5].Value = entity.EntityId;
                    worksheet.Cells[entityRowIndex, 6].Value = entity.EntityName;
                    worksheet.Cells[entityRowIndex, 7].Value = entity.Count;
                    worksheet.Cells[entityRowIndex, 8].Value = entity.LastAccess.ToString();
                    entityRowIndex++;
                }


                int userInfoRowIndex = 2;
                foreach (var userInfo in usersInfo)
                {
                    worksheet.Cells[userInfoRowIndex, 10].Value = userInfo.UserId;
                    worksheet.Cells[userInfoRowIndex, 11].Value = userInfo.RequestCount;
                    worksheet.Cells[userInfoRowIndex, 12].Value = userInfo.AuthCount;

                    StringBuilder permissionsNames = new();
                    userInfo.Permissions.ToList().ForEach(p => permissionsNames.Append(p + "; "));


                    worksheet.Cells[userInfoRowIndex, 13].Value = permissionsNames.ToString();
                    userInfoRowIndex++;
                }

                package.Save();
            }

        }
    }
}
