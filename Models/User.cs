using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_config_demo.Models
{
    [Table("User")]
    public class User
    {
        [Column("Id")]
        public long Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }
        
        [Column("LastName")]
        public string LastName { get; set; }
        
        [Column("Email")]
        public string Email { get; set; }
        
        [Column("Gender")]
        public string Gender { get; set; }
        
        [Column("IpAddress")]
        public string IpAddress { get; set; }
        
        [Column("Country")]
        public string Country { get; set; }
    }
}
