
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pomogite
{
    /// <summary>
    /// класс компании
    /// </summary>
  public class Company
    {
        // названия кмпании
        public string NameCompany { get; set; }
        //коллекция департаментов
        public List<Departament> Departaments { get; set; }
        //коллекция студентов
        public List<Student> students = new List<Student>();
        //коллекция работников
        public List<ClassWorker> workers = new List<ClassWorker>();
        //коллекция новой компании с изменеии зарплаты
        public List<Company> company = new List<Company>();
        //конструктор создания компании
        public Company()
        {

        }
        public Company(string nameCompany, List<Departament> departaments)
        {
            this.NameCompany = nameCompany;
            this.Departaments = departaments;
        }
        public Company(string path)
        {
            company = new List<Company>();
            company = DeserializeXml(path);
        }
        /// <summary>
        /// происходит вывод компании с файла 
        /// </summary>
        public void PrintOld()
        {
            foreach (var item in company)// вывод компании
            {
                Console.WriteLine(item.ToString());
                foreach (var itemDepart in item.Departaments)// вывод департамента
                {
                    Console.WriteLine(itemDepart.ToString());

                    foreach (var itemWork in itemDepart.Workers)// вывод рабочик
                    {
                        Console.WriteLine(itemWork.ToString());
                        if (itemDepart.ID == itemWork.IdDepart)
                        {
                            // запись работников
                        }
                        if (itemDepart.ID > itemWork.IdDepart || itemDepart.ID > itemWork.IdDepart)
                        {

                        }
                    }
                    foreach (var itemStud in itemDepart.Students)// вывод студентов
                    {
                        Console.WriteLine(itemStud.ToString());
                        if (itemDepart.ID == itemStud.IdDepart)
                        {
                          // запись студентов
                        }
                        if (itemDepart.ID > itemStud.IdDepart || itemDepart.ID > itemStud.IdDepart)
                        {

                        }
                    }
                   // запись департаментов
                }
                // запись компании
            } //вывод информации с файла
        }
        /// <summary>
        /// происходит вывод измененной компании с зарплатой работника 
        /// </summary>
        public void PrintNew()
        {
            List<Company> companyNew = new List<Company>();
            List<Departament> departaments = new List<Departament>();
            List<Student> stud = new List<Student>();
            List<ClassWorker> work = new List<ClassWorker>();
            foreach (var item in company)// вывод компании
            {
                foreach (var itemDepart in item.Departaments)// вывод департамента
                {
                    foreach (var itemWork in itemDepart.Workers)// вывод рабочик
                    {
                        if (itemDepart.ID == itemWork.IdDepart)
                        {
                            work.Add(new ClassWorker(itemWork.Name, itemWork.LastName, itemWork.Age, itemWork.Salary, itemWork.IdDepart, itemWork.IdGetDep));// запись работников
                        }
                        if (itemDepart.ID > itemWork.IdDepart || itemDepart.ID > itemWork.IdDepart)
                        {

                        }
                    }
                    foreach (var itemStud in itemDepart.Students)// вывод студентов
                    {
                        if (itemDepart.ID == itemStud.IdDepart)
                        {
                            stud.Add(new Student(itemStud.Name, itemStud.LastName, itemStud.Age, itemStud.Salary, itemStud.IdDepart, itemStud.IdGetDep));// запись студентов
                        }
                        if (itemDepart.ID > itemStud.IdDepart || itemDepart.ID > itemStud.IdDepart)
                        {

                        }
                    }
                    departaments.Add(new Departament(itemDepart.NameDepartament, itemDepart.Quantity, work, stud, itemDepart.ID, itemDepart.IdGetDep));// запись департаментов
                }
                companyNew.Add(new Company(item.NameCompany, departaments));// запись компании
            } //вывод информации с файла
            foreach (var neu in companyNew)// вывод компании
            {
                Console.WriteLine(neu.NameCompany);
                foreach (var neuDep in neu.Departaments)//вывод департамента
                {
                    Console.WriteLine(neuDep.ToString());
                    foreach (var neuWork in neuDep.Workers)// вывод работников
                    {
                        if (neuDep.ID == neuWork.IdDepart)
                        {
                            Console.WriteLine(neuWork.ToString());// запись работников
                        }
                        if (neuDep.ID < neuWork.IdDepart || neuDep.ID > neuWork.IdDepart)
                        {
                        }
                    }
                    foreach (var neuStud in neuDep.Students)// вывод студентов
                    {
                        if (neuDep.ID == neuStud.IdDepart)
                        {
                            Console.WriteLine(neuStud.ToString());
                        }
                        if (neuDep.ID < neuStud.IdDepart || neuDep.ID > neuStud.IdDepart)
                        {
                        }
                    }
                }
            } // вывод новой компании 
        }
        /// <summary>
        /// происходит десериализация файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Company> DeserializeXml(string path)// десериализации Xml
        {

            List<Company> сompany = new List<Company>();

            // создания сериализации для листа
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Company>));

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);// создания потока

            сompany = xmlSerializer.Deserialize(stream) as List<Company>;//десериализация

            stream.Close();// закрытие потока

            return сompany;
        }

        //вывод информации
        public new string ToString()
        {
            return $"Имя компании: {NameCompany}";
        }

    }
}
