using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    internal class laba_3
    {
        static void Main(string[] args)
        {
            Student student = new Student(new Person("Pavel", "Danilov", new DateTime(2021,12, 3)), Education.Specialist, 124);
            student.AddExams(new Exam("Math", 4, new DateTime(2004, 2, 4)), new Exam("History", 3, new DateTime(2005, 2, 5)),
                             new Exam("Russian", 5, new DateTime(1999, 4, 4)), new Exam("Physic", 2, new DateTime(2010, 6, 4)),
                             new Exam("Subject", 1, new DateTime(2023, 2, 10)), new Exam("Subject2", 5, new DateTime(2014, 12, 14)));
            // 1 Задание
            student.sort_name_sub();
            Console.WriteLine("Сортировка по названию предмета:");
            Console.WriteLine(student.ToString());
            Console.WriteLine();

            student.sort_mark();
            Console.WriteLine("Сортировка по оценкам:");
            Console.WriteLine(student.ToString());
            Console.WriteLine();

            student.sort_date();
            Console.WriteLine("Сортировка по дате экзамена");
            Console.WriteLine(student.ToString());
            Console.WriteLine();

            Student student_2 = new Student(new Person("Petr", "Petrov", new DateTime(2021, 12, 3)), Education.Bachelor, 124);
            student_2.AddExams(new Exam("PE", 4, new DateTime(2021, 2, 12)));

            //  2 Задание
            StudentCollection<string> student_collection = new StudentCollection<string>(st => st.GetHashCode().ToString());
            student_collection.AddStudents(student, student_2);
            Console.WriteLine(student_collection);
            student_collection.AddDefaults(2);
            Console.WriteLine(student_collection);

            // 3 Задание
            Console.WriteLine($"Максимальный средний балл: {student_collection.MaxAvgMark}");
            Console.WriteLine();
            Console.WriteLine("Студенты с заданной формой обучения:");
            foreach(var stud in student_collection.EducationForm(Education.Specialist))
            {
                Console.WriteLine(stud.Value);
            }

            Console.WriteLine("Групировка элементов");
            foreach (var group in student_collection.GroupEducation)
            {
                foreach (var stud in group)
                {
                    Console.WriteLine(stud.Value);
                }


            }

            // 4 Задание 
            KeyValuePair<Person, Student> generator (int i)
            {
                Person person = new Person(i.ToString(), i.ToString(), DateTime.MinValue);
                return new KeyValuePair<Person, Student>(person, student);
            }
            TestCollections<Person, Student> test_collections = new TestCollections<Person, Student>(5, generator);
            test_collections.searchListKeys();
            test_collections.searchStringList();
            test_collections.searchdictKey();
            test_collections.searchDictStr();

        }
    }
}
