using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_git.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private string PhoneNumber { get; set; }
        private string location { get; set; }

        public User(string name, string email, string password, string phoneNumber, string location)
        {
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            this.location = location;
        }
    }
}
