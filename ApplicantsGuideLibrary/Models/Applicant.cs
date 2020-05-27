using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Абитуриент - это имя + пароль.
    [Serializable]
    public class Applicant :User
    {
        public List<University> Favorites = new List<University>();
        public Applicant(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
