using System.Web.Mvc;

namespace AspNetMVCFileUpload.Models
{
    public class FileUploadViewModel
    {
        [AllowHtml]
        public string Content { get; set; }
        public string Name { get; set; }
    }
}