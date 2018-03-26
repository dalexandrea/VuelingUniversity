using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1- Create student: ");
            Console.WriteLine("2- Exit: ");
            int option = int.Parse(Console.ReadLine());

            int id;
            string name;
            string surname;
            string dni;


            switch (option)
            {
                case 1:
                    Console.WriteLine("ID: ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Surname: ");
                    surname = Console.ReadLine();
                    Console.WriteLine("DNI: ");
                    dni = Console.ReadLine();

                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\student.txt"))
                    {
                        FileStream FileStream = new FileStream("StudentData.txt", FileMode.Create, FileAccess.Write);
                        writer.WriteLine(id + "," + name + "," + surname + "," + dni);
                    }
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;
                default:
                    break;
            }

        }
    }
}