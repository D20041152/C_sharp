using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mietlabs
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    internal class laba
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Exam[] ex = new Exam[]
            { new Exam(),
            new Exam("Mama", 4, DateTime.Now),
            new Exam("Papa", 5, DateTime.Today)
            };
            student.index();
            student.AddExams(ex);
            Console.WriteLine(student.ToString());
        }
    }
}
