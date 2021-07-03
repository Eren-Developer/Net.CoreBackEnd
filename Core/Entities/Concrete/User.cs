using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User:IEntity  
    {

        public int Id { get; set; }
        public string FirstName { get; set; }

        public String LastName { get; set; }

        public string Email { get; set; }

        public byte[]   PasswordHash { get; set; }

        public byte[] PasswordSalth { get; set; }

        public bool Status { get; set; }

    }

}
