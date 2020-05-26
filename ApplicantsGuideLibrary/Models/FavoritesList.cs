using ApplicantsGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuideLibrary.Models
{
    class FavoritesList
    {
        public List<University> Favorites { get; set; }
        public Applicant Applicant { set; get; }
    }
}
