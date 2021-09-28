using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHBOL
{
    [Table("User")]
    public class User : IdentityUser
    {
        /*
         * All this not required when using Identity User as all of these are already present in IdentityUser Class
        [Key]
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        */
        public IEnumerable<URLs> URLs { get; set; }
    }
}
