
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
            //метод по выводу компании
            AppImplement.ImplementationСompany(path);

        }
    }
}














