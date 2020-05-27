using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Абитуриент - это имя + пароль.
    [Serializable]
    public class Applicant
    {
        public string Name { set; get; }
        public string Password { set; get; }
        public List<University> Favorites = new List<University>();
    }
}
