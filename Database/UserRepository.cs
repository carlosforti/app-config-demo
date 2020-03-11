using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app_config_demo.Models;

namespace app_config_demo.Database
{
    public class UserRepository
    {
        public IEnumerable<User> GetAll()
        {
            var query = new StringBuilder();
            query.AppendLine("SELECT FirstName,");
            query.AppendLine("       LastName,");
            query.AppendLine("       Email,");
            query.AppendLine("       Gender,");
            query.AppendLine("       IpAddress,");
            query.AppendLine("       Country");
            query.AppendLine("FROM   User");

            return new List<User>();
        }
    }
}
