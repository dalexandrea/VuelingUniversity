using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
     {
        string ID;
        string Name;
        String Surname;
        String DNI;

        public void data()
        {
            Console.WriteLine("ID: ");
            ID = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Surname: ");
            Surname = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("DNI: ");
            DNI = Console.ReadLine();
        }
  
        class Program
        {
            static void Main(string[] args)
            {
                int choice = 0;
                Console.WriteLine("1 - Crear New Student, 2 - Exit");
                string stringchoice = Console.ReadLine();
                Int32.TryParse(stringchoice, out choice);

                switch (choice)
                { 
                    case 1:

                        Student S1 = new Student();
                        S1.data();
                        break;
                    case 2:
                        //create text
                }

            }
        }
    }
}
