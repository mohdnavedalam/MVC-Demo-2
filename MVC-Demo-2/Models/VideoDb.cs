using System.Data.Entity;

namespace MVC_Demo_2.Models
{
    public class VideoDb : DbContext
    {
        public VideoDb() : base("DefaultConnection") { }

        public DbSet<Video> Videos { get; set; }
    }
}