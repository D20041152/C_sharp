using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    internal class laba_2
    {
        static void Main(string[] args)
        {
            Person person_1 = new Person("Denis", "Budin", new DateTime(2023, 11, 12));
            Person person_2 = new Person("Denis", "Budin", new DateTime(2023, 11, 12));

            Console.WriteLine($"Объекты класса Person равны: {person_1 == person_2}");

            Console.WriteLine(person_1.GetHashCode());
            Console.WriteLine(person_2.GetHashCode());

            Student student_1 = new Student(person_1, Education.Specialist, 7);

            student_1.AddExams(new Exam(), new Exam(), new Exam("Math", 5, new DateTime(2021, 11, 23)));
            student_1.AddTests(new Test(), new Test(), new Test("Pe", true));
            Console.WriteLine(student_1.ToString());
            Console.WriteLine(student_1.NUMBER_group);
            Student student_3 = new Student();
            student_3 = student_1.DeepCopy() as Student;

            student_1.NUMBER_group = 5;
            person_1.NAME = "Pavel";
            student_1.AddTests(new Test("Music", true));

            Console.WriteLine(student_1.NUMBER_group);
            Console.WriteLine(student_3.NUMBER_group);
            Console.WriteLine(student_1.ToString());
            Console.WriteLine(student_3.ToString());
            Console.WriteLine();

            Console.WriteLine("Список предметов и зачётов:");

            foreach (var item in student_1.iter_testexam())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Список экзаменов с оценкой выше 3:");

            foreach (Exam item in student_1.iter_exam(3))
            {
                Console.WriteLine(item);
            }


        }
    }
}
