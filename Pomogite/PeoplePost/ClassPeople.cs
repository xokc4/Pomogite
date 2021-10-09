using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// шаблон для работников, студентов , директор
    /// </summary>
    class ClassPeople : PeopleInterfeis
    {
        //имя аботника
        public string Name { get; set; }
        //фамилия работника
        public string LastName { get; set; }
        //возраст работника
        public int Age { get; set; }
        //зарплата работника
        public int Salary { get; set; }

        //конструктор работника
       public ClassPeople(string name, string lastName, int age, int salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = SalaryWorks();
        }

        // зарплата студентов
        public int SalaryWorks()
        {
            return 300;
        }
        // зарплата работника
        public int SalaryWorks(int Salary)
        {
            int day = Salary * 8;
            int Moth = day * 28;
            return Moth;
        }
        //зарплата шефа
        public int SalaryWorks(int Salary, int NumberWorks)
        {
            //месячная зарплата работника
            int Moth = (Salary * 8) * 28;
            //зарплата начальника бюро
            int salarychief = ((NumberWorks / 2) * 300 + (NumberWorks / 2) * Moth) * 15 / 100;
            //условие зарплаты работника не меньше 1300
            if (salarychief > 1300)
            {
                return salarychief;
            }
            else
            {
                return 1300;
            }
        }

        //вывод информации
        public override string ToString()
        {
            return $"имя:{Name} фамилия {LastName} возраст{Age} зарплата {Salary}";
        }
    }
}
