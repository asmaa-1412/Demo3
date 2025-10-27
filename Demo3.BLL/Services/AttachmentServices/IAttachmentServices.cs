using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.Services.AttachmentServices
{
    public interface IAttachmentServices
    {
        public string? Uploud(IFormFile file, string folderName);
        public bool Delete(string filePath);
    }
}
