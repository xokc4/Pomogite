using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite.PeoplePost
{
    /// <summary>
    /// наследует конструктор и поля  от ClassPeople, класс для директора
    /// </summary>
  public  class DirectorCompany : ClassPeople, IPeople
    {
        //наследуемый конструктор 

        public DirectorCompany(string name, string lastName, int age, int salary, int idDepart) : base(name, lastName, age, salary, idDepart)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = SalaryWorks();
            this.IdDepart = idDepart;
        }
        public DirectorCompany()
        {

        }
        
        //зарплата директора
        public new int SalaryWorks()
         {

            return 10000000;
         }
        //наследуемый вывод
        public new  string ToString()
        {
            return $"имя директора: {Name} Фамилия: {LastName} Возраст: {Age} зарплата: {Salary}";
        }
    }
}
