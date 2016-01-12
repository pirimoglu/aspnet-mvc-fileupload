using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetMVCFileUpload.Models
{
    public class SampleViewModel
    {
        public SampleViewModel()
        {
            File = new FileUploadViewModel();
        }

        public int Id { get; set; }
        public FileUploadViewModel File { get; set; }
    }
}