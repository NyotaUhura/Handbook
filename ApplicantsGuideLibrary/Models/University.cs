using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Университет – это название + 
    // изображение + адрес + коллекция специальностей.
    [Serializable]
    public class University
    {
        //public University(Bitmap image, string name, string adress, List<Spetiality> spetialities)
        //{
        //    Image = image;
        //    Name = name;
        //    Adress = adress;
        //    Spetialities = spetialities;
        //}

        public string Adress { set; get; }
        public Image Image { set; get; }
        public string Name { set; get; }
        public List<Spetiality> Spetialities { get; set; }
    }
}
