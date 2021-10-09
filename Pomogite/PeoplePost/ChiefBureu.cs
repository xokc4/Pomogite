using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite.PeoplePost
{
    /// <summary>
    /// класс ChiefBureu, наследуется от ClassPeople, PeopleInterfeis
    /// </summary>
    class ChiefBureu : ClassPeople, PeopleInterfeis
    {
        // конструктор для создания ChiefBureu (конструктор наследуется)
        public ChiefBureu(string name, string lastName, int age, int salary, int numberWorksStuds, int salaryWorks) : base(name, lastName, age, salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = SalaryWorks(numberWorksStuds, salaryWorks);
        }
       
        // вывод информации
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
