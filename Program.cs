using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Id=1,Name="Menna",Grade=90.5};
            StudentViewer studentview = new StudentViewer();
            StudentController controller = new StudentController(student,studentview);
            controller.UpdateView();

            controller.SetStudentId(2);
            controller.SetStudentName("Khalil");
            controller.SetStudentGrade(85.5);

            Console.WriteLine("-----------------------------------------------------");
            controller.UpdateView();


        }
    }
}
