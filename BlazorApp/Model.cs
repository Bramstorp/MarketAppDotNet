using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasic
{
    public class GardenContext : DbContext
    {
        public DbSet<Garden> Gardens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433; Database=GardenDb1;User=sa; Password=<StrongPasswordYouSet>");
    }

    public class Garden
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GardenId { get; set; }
        public string Name { get; set; }
    }

}