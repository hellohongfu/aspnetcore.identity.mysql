using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebMvc.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //[System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "bit")]
        //public override bool LockoutEnabled { get => base.LockoutEnabled; set => base.LockoutEnabled = value; }
        //[System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "bit")]
        //public override bool TwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }
        //[System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "bit")]
        //public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }
        //[System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "bit")]
        //public override bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
    }
}
