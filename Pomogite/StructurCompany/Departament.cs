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
        // айди департамента
        public int ID { get; set; }
        // вложенность департамента
        public int IdGetDep { get; set; }
        //конструктор департамента
        public Departament(string nameDepartament, int quantity, List<ClassWorker> workers, List<Student> students, int id, int idGetDep) => (NameDepartament, Quantity, Workers, Students, ID, IdGetDep) = (nameDepartament, quantity, workers, students, id, idGetDep);

        public Departament()
        {

        }
        //вывод информации
        public new string ToString()
        {
            return $"Имя департамента: {NameDepartament} количество сотрудников: {Quantity} вложенность департамента: {IdGetDep}";
        }
    }
}
