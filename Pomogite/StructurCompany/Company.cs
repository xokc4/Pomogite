using Pomogite.PeoplePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// класс компании
    /// </summary>
    class Company
    {
        //имя компании
        public string NameCompany { get; set; }
        //дата создания
        public DateTime DateTime { get; set; }
        //массив бюро
        List<Bureu> Bureus { get; set; }
        //массив департамента
        List<Departament> Departaments { get; set; }
        //массив работников
        List<ClassWorker> ClassWorkers { get; set; }
        //массив студентов
        List<Student> Students { get; set; }
        //директор компании
        public DirectorCompany Director { get; set; }
        //конструктор создания компании

        public Company(string nameCompany, DateTime dateTime, List<Bureu> bureus, List<Departament> departaments, List<ClassWorker> classWorkers, List<Student> students, DirectorCompany director) => 
            (NameCompany, DateTime, Bureus, Departaments, ClassWorkers, Students, Director) =
            (nameCompany, dateTime, bureus, departaments, classWorkers, students, director);
        //вывод информации
        public new string ToString()
        {
            return $"Имя: {NameCompany} Дата создания: {DateTime}";
        }

    }
}
