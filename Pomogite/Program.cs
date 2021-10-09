using Pomogite.PeoplePost;
using System;
using System.Collections.Generic;

namespace Pomogite
{
    class Program
    {
        /// <summary>
        /// программа реализует компанию с департаментами и бюро с сотрудниками
        /// присуствует два метода один по созданию , а  другой по выводу информации
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CreatureCompany();
        }
        public static void CreatureCompany ()
        {
            //рандомайз
            Random random = new Random();
            //коллекция департаментов
            List<Departament> departaments = new List<Departament>();
            //коллекция бюро
            List<Bureu> bureus = new List<Bureu>();
            //коллекция студентов
            List<Student> students = new List<Student>();
            //коллекция работников
            List<ClassWorker> workers = new List<ClassWorker>();

            Console.WriteLine("напишите общее количество бюро"); 
            //количество бюро
            int NumbBur = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i< NumbBur; i++)//цикл по созданию бюро
            {
                Console.WriteLine("напишие количество департаментов");
                //количество департаментов
                int NumbDepart = Convert.ToInt32(Console.ReadLine());
                //количество работников
                int NumbEmples = 6;
                Console.WriteLine("напишите зарплату в час для работника");
                //зарплата сотрудников
                int salaryWorks = Convert.ToInt32(Console.ReadLine());
                ChiefBureu chiefBureu = new ChiefBureu("Name_shief", "LastName_Shief", 20, 200, NumbEmples, salaryWorks);//создания нальника бюро
                bureus.Add(new Bureu($"Бюро_{i+1}", NumbDepart, departaments, chiefBureu));//добавление бюро
               
                for (int g=0; g< NumbDepart; g++)//цикл создания департаментов
                {
                    departaments.Add(new Departament($"Departament_{g+1}", NumbEmples, workers, students));//добавления департамента
                    int DepartStudWorks = NumbEmples / 2;//количество студентов 
                    for(int u=0; u<DepartStudWorks; u++)//цикл создания работников
                    {
                        workers.Add(new ClassWorker($"Name_{u}",$"LastName_{u}", random.Next(20, 28), salaryWorks));//создания работников
                      
                    }
                    for(int y=0; y<DepartStudWorks; y++)//цикл создания студентов
                    {
                        students.Add(new Student($"Name_{y}", $"LastName_{y}", random.Next(17, 20), 0));//создания студентов
                        
                    }
                }
                Console.WriteLine("напишите 1 для добавления бюро");
                switch (Console.ReadLine())//условие по добавлению бюро в бюро
                {
                    case "1":
                        CreatureCompany();
                        break;
                    default:
                        Console.WriteLine("пока");
                        break;
                }
                Conclusion(departaments, bureus, students, workers);// вывод информации
            }
        }
        public static void Conclusion(List<Departament> departaments, List<Bureu> bureus, List<Student> students, List<ClassWorker> workers)
        {
            Random random = new Random();
            DirectorCompany directorCompany = new DirectorCompany("Name_Director", "LastName-Director", random.Next(45, 60), 0);//создания директора 
            Company company = new Company("NewCompany", DateTime.Now, bureus, departaments, workers, students, directorCompany);//создания компании
            
            Console.WriteLine(company.ToString());//вывод компании
            Console.WriteLine(directorCompany.ToString());//вывод директора
            foreach (var i in bureus)
            {

                Console.WriteLine(i.ToString());//вывод бюро
                Console.WriteLine(i.ChiefBureu.ToString());// вывод начальника бюро
                foreach (var g in departaments)
                {
                    Console.WriteLine(g.ToString());//вывод департаментов
                    foreach (var p in workers)//
                    {
                        Console.WriteLine(p.ToString());//вывод работников
                    }
                    foreach (var c in students)//
                    {
                        Console.WriteLine(c.ToString());//вывод студентов
                    }
                }
            }
        }
    }
}

