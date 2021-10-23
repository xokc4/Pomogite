
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Pomogite
{
    class Program
    {
        static void Main(string[] args)
        {
            //путь файла
            string path = @"Company.xml";
                
            Company company = new Company(path);
            //вывод компании с файла
            company.PrintOld();
            // вывод измененной компании
            company.PrintNew();
        }
    }
}














