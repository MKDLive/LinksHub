using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHBOL
{
    [Table("URLs")]
    public class URLs
    {
        [Key]
        public int UrlId { get; set; }
        public string UrlTitle { get; set; }
        public string UrlName { get; set; }
        public string UrlDescription { get; set; }
        public bool IsApproved { get; set; }

        [ForeignKey("User")]
        public User UserId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }

    }
}
