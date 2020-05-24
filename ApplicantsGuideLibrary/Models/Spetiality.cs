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
        //public Spetiality(string name, int price, double contest, int stateFundedPlaces, int dayPlaces, int correspondencePlaces)
        //{
        //    Name = name;
        //    Price = price;
        //    Contest = contest;
        //    StateFundedPlaces = stateFundedPlaces;
        //    DayPlaces = dayPlaces;
        //    СorrespondencePlaces = correspondencePlaces;
        //    Places = dayPlaces + correspondencePlaces;
        //}
        public string Name { set; get; }
        public decimal Price { set; get; }
        public double Contest { set; get; }
        public int StateFundedPlaces { set; get; }
        public int DayPlaces { set; get; }
        public int СorrespondencePlaces { set; get; }
        public int Places { set; get; }
    }
}
