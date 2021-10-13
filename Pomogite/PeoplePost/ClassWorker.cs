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
   public class ClassWorker : ClassPeople, IPeople
    {
        public ClassWorker()
        {

        }
        public ClassWorker(string name, string lastName, int age, int salary, int idDepart) : base(name, lastName, age, salary, idDepart)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = SalaryWorks(salary);
            this.IdDepart = idDepart;
        }

        //конструктор наследования

        //вывод информации
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
