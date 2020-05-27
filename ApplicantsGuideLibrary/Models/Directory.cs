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
    // Справочник – это коллекция университетов + коллекция абитуриентов + администратор.
    [Serializable]
    public class Directory
    {
        public Admin Admin{ set; get; }
        public List<University> Universities { private set; get; }
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
                    (
                        $"Spetiality{j}",
                        j * 1000 + 10000,
                        170 + j,
                        30 + j,
                        80 + j,
                        j
                    ));
                }
                Universities.Add(new University
                (
                    //Image = noImage,
                    $"Kharkiv, Naukova street, {i}",
                    $"University{i}",
                    spetialities
                ));
            }
            Applicants.Clear();
            // Абитуриенты.
            Applicants = new List<Applicant>();
            for (int i = 0; i < n; i++)
            {
                Applicants.Add(new Applicant ( $"Applicant{i}", "123" ));
            }

            ////Админ.
            
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
