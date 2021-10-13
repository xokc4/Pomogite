using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// интерфейс работников 
    /// </summary>
    interface IPeople
    {
        /// <summary>
        /// есть 3 метода по создании зарплаты 
        /// метод без переменных для студентов, метод  с одной переменной для работников, метод с двумя переменнами для начальника бюро
        /// </summary>
        /// <returns></returns>
        int SalaryWorks();
        int SalaryWorks(int Salary);
        int SalaryWorks(int Salary, int NumberWorks);

    }
}
