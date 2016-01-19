using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVCFileUpload.Models
{
    public class SampleViewModel
    {
        public SampleViewModel()
        {
            File = new FileUploadViewModel();
            Image = new ImageUploadViewModel();
        }

        public int Id { get; set; }
        public FileUploadViewModel File { get; set; }
        public ImageUploadViewModel Image { get; set; }
    }
}