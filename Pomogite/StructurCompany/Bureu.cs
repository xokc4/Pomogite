using Pomogite.PeoplePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomogite
{
    /// <summary>
    /// класс бюро 
    /// </summary>
    class Bureu
    {
       //директор бюро
       public ChiefBureu ChiefBureu;
       //имя бюро
       public string NameBureu { get; set; }
        //количество департаментов
       public int QuantityDepartaments { get; set; }
        //массив с департаментами
        public List<Departament> Departaments { get; set; }
        // конструктор бюро
        public Bureu(string nameBureu, int quantityDepartaments, List<Departament> departaments, ChiefBureu chiefBureu) => (NameBureu, QuantityDepartaments, Departaments, ChiefBureu) = (nameBureu, quantityDepartaments, departaments, chiefBureu);
        //вывод информации
        public new string ToString()
        {
            return $"имя: {NameBureu} количество департаментов: {QuantityDepartaments}";
        }
    }
}
