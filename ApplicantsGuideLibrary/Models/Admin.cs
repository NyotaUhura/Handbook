using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Администратор - это имя + пароль.
    [Serializable]
    public class Admin
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
