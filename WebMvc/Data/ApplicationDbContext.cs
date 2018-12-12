using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebMvc.Models;
using Microsoft.AspNetCore.Identity;

namespace WebMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);



            builder.Entity<ApplicationUser>(b => {

                b.HasKey(p => p.Id);
                b.Property(p => p.LockoutEnabled).HasColumnType("bit");
                b.Property(p => p.TwoFactorEnabled).HasColumnType("bit");
                b.Property(p => p.PhoneNumberConfirmed).HasColumnType("bit");
                b.Property(p => p.EmailConfirmed).HasColumnType("bit");

            });
            builder.Entity<IdentityUserLogin<string>>(b => {

                b.HasKey(p => new { p.UserId,p.LoginProvider,p.ProviderKey });

                b.Property(p => p.UserId).HasMaxLength(50);
                b.Property(p => p.LoginProvider).HasMaxLength(50);
                b.Property(p => p.ProviderKey).HasMaxLength(50);
               

            });

            builder.Entity<IdentityUserLogin<string>>(b => {

                b.HasKey(p => new { p.UserId, p.LoginProvider, p.ProviderKey });

                b.Property(p => p.UserId).HasMaxLength(50);
                b.Property(p => p.LoginProvider).HasMaxLength(50);
                b.Property(p => p.ProviderKey).HasMaxLength(50);


            });

            builder.Entity<IdentityUserRole<string>>(b => {

                b.HasKey(p => new { p.UserId, p.RoleId });

                b.Property(p => p.UserId).HasMaxLength(50);
                b.Property(p => p.RoleId).HasMaxLength(50);


            });


            builder.Entity<IdentityUserToken<string>>(b => {

                b.HasKey(p => new { p.UserId, p.LoginProvider,p.Name });

                b.Property(p => p.UserId).HasMaxLength(50);
                b.Property(p => p.Name).HasMaxLength(50);
                b.Property(p => p.LoginProvider).HasMaxLength(50);



            });


        }


    }
}
