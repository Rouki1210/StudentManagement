using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagement
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public User(int id, string name, string email, string phone) 
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
