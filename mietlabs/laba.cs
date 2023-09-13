using System;
using System.Diagnostics;
using System.Linq;

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

        static void timer(ref Student st)
        {
            Stopwatch stopWatch_1 = new Stopwatch();
            stopWatch_1.Start();
            Console.WriteLine(st.ToString());
            stopWatch_1.Stop();
            Console.WriteLine(stopWatch_1.Elapsed.TotalSeconds);
        }

        static void Main(string[] args)
         {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nrow = input[0];
            int ncol = input[1];
            Person pers = new Person("Александр", "Иванов", DateTime.Now);
            Student student = new Student(pers, Education.Bachelor, 2);
            Console.WriteLine(student.ToShortString() + "\n");

            student.index();

            Console.WriteLine(student.ToString());
            Exam[] ex = new Exam[nrow * ncol];
            for (int i = 0; i < nrow * ncol; i++)
            {
                ex[i] = new Exam();
            }
            student.AddExams(ex);
            timer(ref student);
            Exam[,] ex_2 = new Exam[nrow, ncol];

            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    ex_2[i, j] = new Exam();
                }
            }
            Student student_2 = new Student(pers, Education.Bachelor, 2);

            student_2.AddExams(ex_2);
            timer(ref student_2);


            Exam[][] ex_3 = new Exam[nrow][];
            for (int i = 0; i < nrow; i++)
            {
                ex_3[i] = new Exam[ncol];
            }
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    ex_3[i][j] = new Exam();
                }
            }

            Student student_3 = new Student(pers, Education.Bachelor, 2);
            student_3.AddExams(ex_3);
            timer(ref student_3);

        }
    }
}
