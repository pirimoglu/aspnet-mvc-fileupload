using AspNetMVCFileUpload.Entities;
using System.Data.Entity;

namespace AspNetMVCFileUpload
{
    public class MainContext : DbContext
    {
        public DbSet<Sample> Samples { get; set; }
    }
}