using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_config_demo.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string IpAddress { get; set; }
        public string Country { get; set; }
    }
}
