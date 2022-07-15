using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;

namespace ReflectionLets
{
    public class Program
    {
        static void DisplayPublicProperties(object obj)
        {

            var tipo = obj.GetType();
            var builder = new StringBuilder();

            foreach(var p in tipo.GetProperties()) {
            builder.AppendLine(p.Name + ": " + p.GetValue(obj));
            }

            Console.WriteLine(builder);
        }

        public static void CreateInstance(object obj)
        {
            var types = obj.GetType();
            var builder = new StringBuilder();

            foreach (var type in types.GetProperties()) {

                    builder.AppendLine(type.Name + ": " + type.GetValue(obj));
                }

            var newStudent = new Student("Fábio", "FMU", 12345);
            DisplayPublicProperties(newStudent);
            newStudent.DisplayInfo();
        }

        static void Main() {

            //Estilo 1
            var aluno1 = new Student() { Name = "Fábio", University = "FMU", RollNumber = 12345 };
            var aluno2 = new Student() { Name = "Lucio", University = "Uninove", RollNumber = 67890 };

            DisplayPublicProperties(aluno1);

            //Estilo 2
            CreateInstance(new Student("Fábio", "FMU", 12345));
        }

    }

}
