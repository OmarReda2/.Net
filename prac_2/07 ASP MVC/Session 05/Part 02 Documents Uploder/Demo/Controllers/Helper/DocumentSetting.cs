using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Demo.Controllers.Helper
{
    public static class DocumentSetting
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            /// 1. Get Located Folder Path
            //var folder = @"E:\omar\Programming (Practice & Projects)\Courses Practice\ASP.NET temp\Part 02 Documents Uploder\Demo\wwwroot\files\imgs\";
            //var folder = Directory.GetCurrentDirectory() + "/wwwroot/files" + folderName;
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", folderName);

            /// 2. Get file name and make its name unique
            var fileName = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}";//file name will return the file name and the extension

            /// 3. Get file path
            var filePath = Path.Combine(folderPath, fileName);

            /// 4. Save file as stream
            using var fs = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fs);

            return fileName;
            
            /// 5. Go to the Create Action and upload file using this function
        }
    
    
        public static void DeleteFile(string fileName, string folderName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", folderName, fileName);

            if(File.Exists(filePath))
                File.Delete(filePath);


        }
    }
}
