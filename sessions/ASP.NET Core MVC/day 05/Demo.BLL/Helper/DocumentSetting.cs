using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Helper
{
    public class DocumentSetting
    {
        #region
        public static string Upload(IFormFile File, string FolderName)
        {
            string folderPadth = Directory.GetCurrentDirectory() + "/wwwroot/Files/" + FolderName;
            string fileName = Guid.NewGuid() + Path.GetFileName(File.FileName);
            string filePath = Path.Combine(folderPadth, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                File.CopyTo(fileStream);
            }

            return fileName;
            #endregion

        }
    }
}
