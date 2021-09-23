using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHBOL
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public IEnumerable<URLs> URLs { get; set; }
    }
}
