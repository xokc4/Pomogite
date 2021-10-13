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
   public class Departament
    {
        //имя департамента
        public string NameDepartament { get; set; }
        //количество сотрудников
        public int Quantity { get; set; }
        //массив с работниками
        public List<ClassWorker> Workers { get; set; }
        //массив с студентами 
        public List<Student> Students { get; set; }

        public int ID { get; set; }
        //конструктор департамента
        public Departament(string nameDepartament, int quantity, List<ClassWorker> workers, List<Student> students, int id) => (NameDepartament, Quantity, Workers, Students, ID) = (nameDepartament, quantity, workers, students, id);

        public Departament()
        {

        }
        //вывод информации
        public new string ToString()
        {
            return $"Имя департамента: {NameDepartament} количество сотрудников: {Quantity}";
        }
    }
}
