﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    [Serializable]
    public abstract class User
    {
        public string Name { set; get; }
        public string Password { set; get; }
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
