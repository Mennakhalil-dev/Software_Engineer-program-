using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    internal class StudentViewer
    {
        public void DisplayStudentDetails(int Id, string Name, double Grade)
            {
            Console.WriteLine("Student Details: ");
            Console.WriteLine("Student Id: " + Id);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Grade: " + Grade);
            }
    }
}
