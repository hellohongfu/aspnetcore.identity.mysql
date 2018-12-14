using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebMvc.Models.BusinessModel;


namespace WebMvc.Data
{
    public class ApplicationBusinessContext : DbContext
    {

        public ApplicationBusinessContext(DbContextOptions<ApplicationBusinessContext> options)
            : base(options)
        {

        }
        public DbSet<WebMvc.Models.BusinessModel.Task> tasks { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WebMvc.Models.BusinessModel.Task>(e =>
            {
                e.Property(p => p.IsComplated).HasColumnType("bit");
            }
            );
        }

    }


}
