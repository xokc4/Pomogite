using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// наследует конструктор и поля  от ClassPeople, класс для работника
    /// </summary>
    class ClassWorker : ClassPeople, PeopleInterfeis
    {
        //конструктор наследования
        public ClassWorker(string name, string lastName, int age, int salary) : base(name, lastName, age, salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = SalaryWorks(salary);
        }
        //вывод информации
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
