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

        public Student()
        {
            Guid = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                ID == student.ID &&
                Name == student.Name &&
                Surname == student.Surname &&
                Dni == student.Dni && Guid == student.Guid;
        }

        public override int GetHashCode()
        {
            var hasCode =  
            return hashCode;
        }
    }
}

