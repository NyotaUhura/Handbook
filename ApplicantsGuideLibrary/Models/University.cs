using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Университет – это идентификатор + название + 
    // изображение + адрес + коллекция специальностей.
    [Serializable]
    public class University
    {
        public University(int id, string name, string adress, List<Spetiality> spetialities)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Spetialities = spetialities;
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public string Adress { set; get; }
        public List<Spetiality> Spetialities { get; set; }
    }
}
