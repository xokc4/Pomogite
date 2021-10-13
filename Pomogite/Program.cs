using Pomogite.PeoplePost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Pomogite
{
    class Program
    {
        /// <summary>
        /// происходит реализация вывод департаментов, работников, студентов и изменение к зарплаты с файлов
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"Company.xml";
            //коллекция департаментов
            List<Departament> departaments = new List<Departament>();
            //коллекция студентов
            List<Student> students = new List<Student>();
            //коллекция работников
            List<ClassWorker> workers = new List<ClassWorker>();
            //директор
            DirectorCompany director = new DirectorCompany();
            //коллекция компания с файлов 
            List<Company> company = DeserializeXml(path);
            //коллекция новой компании с изменеии зарплаты
            List<Company> companyPosle = new List<Company>();
           
            foreach(var item in company)// вывод компании
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(director.ToString());
                foreach(var itemDepart in item.Departaments)// вывод департамента
                {
                    Console.WriteLine(itemDepart.ToString());
                    
                    foreach(var itemWork in itemDepart.Workers)// вывод рабочик
                    {
                        Console.WriteLine(itemWork.ToString());
                        workers.Add(new ClassWorker(itemWork.Name, itemWork.LastName, itemWork.Age, itemWork.Salary, itemWork.IdDepart));// запись работников
                    }
                    foreach(var itemStud in itemDepart.Students)// вывод студентов
                    {
                        Console.WriteLine(itemStud.ToString());
                        students.Add(new Student(itemStud.Name, itemStud.LastName, itemStud.Age, itemStud.Salary, itemStud.IdDepart));// запись студентов
                    }
                    departaments.Add(new Departament(itemDepart.NameDepartament, itemDepart.Quantity, workers, students, itemDepart.ID));// запись департаментов
                }
                companyPosle.Add(new Company(item.NameCompany, departaments, workers, students, item.Director));// запись компании
            } //вывод информации с файла


            foreach (var neu in companyPosle)// вывод компании
            {
                Console.WriteLine(neu.NameCompany);
                Console.WriteLine(neu.Director.ToString());
                foreach(var neuDep in neu.Departaments)//вывод департамента
                {
                    Console.WriteLine(neuDep.ToString());
                    foreach(var neuWork in neuDep.Workers)// вывод работников
                    {
                        
                        Console.WriteLine(neuWork.ToString());
                    }
                    foreach(var neuStud in neuDep.Students)// вывод студентов
                    {
                        Console.WriteLine(neuStud.ToString());
                    }
                }
            } // вывод новой компании 
        }
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
    }
}














