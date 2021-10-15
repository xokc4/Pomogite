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
  public class Company
    {
        //имя компании
        public string NameCompany { get; set; }
      public List<Departament> Departaments { get; set; }
        //массив работников

        //директор компании
        public DirectorCompany Director { get; set; }
        //конструктор создания компании

        public Company()
        {

        }
        public Company(string nameCompany, List<Departament> departaments, DirectorCompany director)
        {
            this.NameCompany = nameCompany;
            this.Departaments = departaments;
            
            this.Director = director;
        }
           
        //вывод информации
        public new string ToString()
        {
            return $"Имя компании: {NameCompany}";
        }

    }
}
