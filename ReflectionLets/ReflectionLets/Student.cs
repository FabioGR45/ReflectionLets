using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLets
{
    public class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }

        public Student()
        {

        }
        public Student(string Name, string University, int number)
        {
            this.Name = Name;
            this.University = University;
            this.RollNumber = number;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {University} - {RollNumber}");
        }
    }

}
