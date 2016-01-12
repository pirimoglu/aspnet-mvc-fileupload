using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMVCFileUpload.Entities
{
    [ComplexType]
    public class FileUpload
    {
        public string Content { get; set; }
        public string Name { get; set; }
    }
}