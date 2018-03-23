using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Student
    {
        string ID;
        string Name;
        string Surname;
        string DNI;


        public void data()
        {
            Console.WriteLine("ID: ");
            ID = Console.ReadLine();
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            Surname = Console.ReadLine();
            Console.WriteLine("DNI: ");
            DNI = Console.ReadLine();
        }
        class Student1
        {

            static void Main(string[] args)
            {
                Student S1 = new Student();
                S1.data();
            }
        }
    }
}