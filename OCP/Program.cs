using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
     public class Program
    {
        static void Main(string[] args)
        {
            var onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso de en Línea" };
            var onsiteCourse = new OnsiteCourse { CourseId = 2, Title = "Curso de Presencial" };
            var hybridCourse = new HybridCourse { CourseId = 3, Title = "Curso de Híbrido" };

            var student = new Student { Id = 1, Nombre = "Ramon" };

            onlineCourse.Subscribe(student);
            onsiteCourse.Subscribe(student);
            hybridCourse.Subscribe(student);
            Console.ReadKey();
        }
    }
     public class Student
    {
        public int Id;
        public string Nombre;

    }
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student student);

    }
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha suscrito al curso en linea {Title}");

        }
    }
    public class OnsiteCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha suscrito al curso presencial {Title}");
        }
    }
    public class HybridCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha suscrito al curso híbrido {Title}.");

        }
    }
}
