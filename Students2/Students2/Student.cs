using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2
{
    public class Student
    {
        public Guid Guid { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }

        public Student(Guid guid, int id, string name, string surname, string dni)
        {
            this.Guid = guid;
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Dni = dni;
        }
        
    }
}

