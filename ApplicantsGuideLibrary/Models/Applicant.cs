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
        public Applicant(string name, string password) : base(name, password)
        {
            Name = name;
            Password = password;
        }
        public void AddUniversity(University university)
        {
            var check = false;
            foreach (var un in Favorites)
            {
                if (un.Name == university.Name)
                    check = true;
            }
            if (check == false)
            {
                Favorites.Add(university);
            }
            
        }
    }
}
