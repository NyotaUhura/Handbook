using ApplicantsGuide.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsGuide.Models
{
    // Справочник – это коллекция университетов + коллекция абитуриентов.
    [Serializable]
    public class Directory
    {
        //Список университетов.
        public List<University> Universities { private set; get; }
        //Список абитуриентов.
        public List<Applicant> Applicants { private set; get; }
        public Directory()
        {
            Universities = new List<University>();
            Applicants = new List<Applicant>();
        }

        //Заполнение тестовых данных.
        public void FillTestData(int n)
        {
            Universities.Clear();
            //var noImage = new Bitmap(Path.GetFullPath("empty.png"));
            // Университеты.
            Universities = new List<University>();
            for (int i = 0; i < n - 5; i++)
            {
                //Специальности.
                var spetialities = new List<Spetiality>();
                for (int j = 0; j < 5; j++)
                {
                    spetialities.Add(new Spetiality
                    {
                        Name = $"Spetiality{j}",
                        Price = j * 1000 + 10000,
                        Contest = 170 + j,
                        StateFundedPlaces = 30 + j,
                        DayPlaces = 80 + j,
                        СorrespondencePlaces = j,
                        Places = 2 * j + 80
                    });
                }
                Universities.Add(new University 
                { 
                    //Image = noImage,
                    Name = $"University{i}", 
                    Adress = $"Kharkiv, Naukova street, {i}", 
                    Spetialities = spetialities 
                });
            }
            Applicants.Clear();
            // Абитуриенты.
            Applicants = new List<Applicant>();
            for (int i = 0; i < n; i++)
            {
                Applicants.Add(new Applicant { Name = $"Applicant{i}", Password = "123" });
            }
        }
            //Сохранение и загрузка данных.
            public void Save()
            {
                new Dao(this).Save();
            }
            public void Load()
            {
                new Dao(this).Load();
            }
    }
}
