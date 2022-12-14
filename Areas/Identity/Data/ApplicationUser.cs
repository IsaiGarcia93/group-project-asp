using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GroupProject.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AppliocationUser class
    public class ApplicationUser : IdentityUser
    {               
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }
        
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }
            
        [PersonalData]
        [Column(TypeName = "nvarchar(2)")]
        public string State { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(6)")]
        public string Zip { get; set; }
    }
}
