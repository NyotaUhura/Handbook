using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Специальность – это название + цена обучения + проходной балл на бюджет +
    // кол-во мест на обучение на бюджетной основе + кол-во мест на дневную форму +
    // кол-в мест на заочную форму обучения + кол-во всех мест.
    [Serializable]
    public class Spetiality
    {
        public Spetiality(string name, decimal price, decimal contest, decimal stateFundedPlaces, 
            decimal dayPlaces, decimal correspondencePlaces)
        {
            Name = name;
            Price = price;
            Contest = contest;
            StateFundedPlaces = stateFundedPlaces;
            DayPlaces = dayPlaces;
            СorrespondencePlaces = correspondencePlaces;
            Places = correspondencePlaces + dayPlaces;
        }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public decimal Contest { set; get; }
        public decimal StateFundedPlaces { set; get; }
        public decimal DayPlaces { set; get; }
        public decimal СorrespondencePlaces { set; get; }
        public decimal Places { set; get; }
    }
}
