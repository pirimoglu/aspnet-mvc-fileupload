using System.Web.Mvc;

namespace AspNetMVCFileUpload.Models
{
    public class ImageUploadViewModel : FileUploadViewModel
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}