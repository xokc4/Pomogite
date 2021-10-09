using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// наследует конструктор и поля  от ClassPeople, класс для студентов
    /// </summary>
    class Student : ClassPeople, PeopleInterfeis
    {
        //наследуемый коструктор для студента 
        public Student(string name, string lastName, int age, int salary) : base(name, lastName, age, salary)
        {
        }
        //наследуемый вывод
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
