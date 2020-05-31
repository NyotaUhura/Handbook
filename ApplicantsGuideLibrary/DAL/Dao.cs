using ApplicantsGuide.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Directory = ApplicantsGuide.Models.Directory;

namespace ApplicantsGuide.DAL
{
    class Dao
    {
        Directory directory;
        const string filePath = "directory.bin";

        public Dao(Directory directory)
        {
            this.directory = directory;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, directory);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Directory dr = (Directory)serializer.Deserialize(stream);
                Copy(dr.Applicants, directory.Applicants);
                Copy(dr.Universities, directory.Universities);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
        //private readonly Models.Directory directory;
        //const string APPLICANTS = "applicants.txt";
        //const string UNIVERSITIES = "universities.txt";
        //public Dao(Models.Directory directory)
        //{
        //    this.directory = directory;
        //}
        ////Сохранение данных.
        //public void Save()
        //{
        //    SaveApplicants();
        //    SaveUniversities();
        //}
        //private void SaveApplicants()
        //{
        //    using (var wr = new StreamWriter(APPLICANTS))
        //    {
        //        wr.WriteLine(directory.Applicants.Count);
        //        foreach (var a in directory.Applicants)
        //        {
        //            wr.WriteLine(a.Name);
        //            wr.WriteLine(a.Password);
        //        }
        //    }
        //}
        //private void SaveUniversities()
        //{
        //    using (var wr = new StreamWriter(UNIVERSITIES))
        //    {
        //        wr.WriteLine(directory.Universities.Count);
        //        foreach (var u in directory.Universities)
        //        {
        //            wr.WriteLine(u.Adress);
        //            wr.WriteLine(u.Id);
        //            wr.WriteLine(u.Name);
        //            wr.WriteLine(u.Spetialities.Count);
        //            foreach (var s in u.Spetialities)
        //            {
        //                wr.WriteLine(s.Contest);
        //                wr.WriteLine(s.СorrespondencePlaces);
        //                wr.WriteLine(s.DayPlaces);
        //                wr.WriteLine(s.Name);
        //                wr.WriteLine(s.Places);
        //                wr.WriteLine(s.Price);
        //                wr.WriteLine(s.StateFundedPlaces);
        //            }
        //        }
        //    }
        //}

        ////Загрузка данных.
        //public void Load()
        //{
        //    LoadApplicants();
        //    LoadUniversities();
        //}
        //private void LoadApplicants()
        //{
        //    using (var rd = new StreamReader(APPLICANTS))
        //    {
        //        int n = Convert.ToInt32(rd.ReadLine());
        //        directory.Applicants.Clear();
        //        for (int i = 0; i < n; i++)
        //        {
        //            directory.Applicants.Add(new Applicant
        //            {
        //                Name = rd.ReadLine(),
        //                Password = rd.ReadLine(),
        //            });
        //        }
        //    }
        //}
        //private void LoadUniversities()
        //{
        //    using (var rd = new StreamReader(UNIVERSITIES))
        //    {
        //        int n = Convert.ToInt32(rd.ReadLine());
        //        directory.Universities.Clear();
        //        for (int i = 0; i < n; i++)
        //        {
        //            var adress = rd.ReadLine();
        //            var id = Convert.ToInt32(rd.ReadLine());
        //            var name = rd.ReadLine();
        //            var ss = ReadSpetialities(rd);
        //            directory.Universities.Add(new University(id, name, adress, ss));
        //        }
        //    }
        //}
        //private List<Spetiality> ReadSpetialities(StreamReader rd)
        //{
        //    int n = Convert.ToInt32(rd.ReadLine());
        //    var ss = new List<Spetiality>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        var contest = Convert.ToDouble(rd.ReadLine());
        //        var correspondancePlaces = Convert.ToInt32(rd.ReadLine());
        //        var dayPlaces = Convert.ToInt32(rd.ReadLine());
        //        var name = rd.ReadLine();
        //        var places = Convert.ToInt32(rd.ReadLine());
        //        var price = Convert.ToDecimal(rd.ReadLine());
        //        var stateFundedPlaces = Convert.ToInt32(rd.ReadLine());
        //        ss.Add(new Spetiality
        //        {
        //            Contest = contest,
        //            СorrespondencePlaces = correspondancePlaces,
        //            DayPlaces = dayPlaces,
        //            Name = name,
        //            Places = places,
        //            Price = price,
        //            StateFundedPlaces = stateFundedPlaces
        //        });
        //    }
        //    return ss;
        //}

        //private University GetUniversityById(int universityId)
        //{
        //    foreach (var u in directory.Universities)
        //    {
        //        if (u.Id == universityId)
        //            return u;
        //    }
        //    throw new Exception();
        //}

    }
}
