using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.Services.AttachmentServices
{
    public class AttachmentServices : IAttachmentServices
    {
        internal List<string> AllowedExtenstion = [".png",".jpg",".jpeg"];
        const int _max_size = 2_097_152;
        public string? Uploud(IFormFile file, string folderName)
        {
            var extention = Path.GetExtension(file.FileName);
            if (!AllowedExtenstion.Contains(extention)) return null;
            if (file.Length == 0 || file.Length > _max_size) return null;
            var folderPath =Path.Combine( Directory.GetCurrentDirectory(), "wwwroot","Fils","Images");
            var fileName = $"{Guid.NewGuid()}_{file.FileName}";
            var filePath = Path.Combine(folderPath, fileName);
            using FileStream fs = new FileStream(filePath,FileMode.Create);
            file.CopyTo(fs);
            return fileName;
        }
        public bool Delete(string filePath)
        {
            if (!File.Exists(filePath)) return false;
            File.Delete(filePath);
            return true;
        }

    }
}
