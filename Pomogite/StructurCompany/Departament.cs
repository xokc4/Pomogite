using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// класс для департамента 
    /// </summary>
    class Departament
    {
        //имя департамента
        public string NameDepartament { get; set; }
        //количество сотрудников
        public int Quantity { get; set; }
        //массив с работниками
        public List<ClassWorker> Workers { get; set; }
        //массив с студентами 
        public List<Student> Students { get; set; }
        //конструктор департамента
        public Departament(string nameDepartament, int quantity, List<ClassWorker> workers, List<Student> students) => (NameDepartament, Quantity, Workers, Students) = (nameDepartament, quantity, workers, students);

        //вывод информации
        public new string ToString()
        {
            return $"Имя: {NameDepartament} Количество сотрудников: {Quantity}";
        }
    }
}
