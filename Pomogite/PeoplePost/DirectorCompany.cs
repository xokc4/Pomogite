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
    class DirectorCompany : ClassPeople, PeopleInterfeis
    {
        //наследуемый конструктор 
        public DirectorCompany(string name, string lastName, int age, int salary) : base(name, lastName, age, salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = SalaryWorks();
        }
        //зарплата директора
         public new int SalaryWorks()
         {

            return 10000000;
         }
        //наследуемый вывод
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
