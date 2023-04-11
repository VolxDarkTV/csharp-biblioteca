﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {

        public User(string name, string last, string email, string password, string phone)
        {
            this.Name = name;
            this.Last = last;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
        }

        public string Name { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

    }
}
