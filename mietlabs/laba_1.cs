using System;
using System.Diagnostics;
using System.Linq;

namespace laba_1
{
    enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
    internal class laba_1
    {

        static double timer(in Student st)
        {
            Stopwatch stopWatch_1 = new Stopwatch();
            stopWatch_1.Start();
            Console.WriteLine(st.ToString());
            stopWatch_1.Stop();
            return stopWatch_1.Elapsed.TotalSeconds;
        }

        static void Main(string[] args)
         {
            Console.WriteLine("nrow ncols");
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

            double t_1 = timer(student);

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
            double t_2 = timer(student_2);


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
            double t_3 = timer(student_3);

            Console.WriteLine($"Одномерный массив - {t_1}");
            Console.WriteLine($"Прямоугольный массив - {t_2}");
            Console.WriteLine($"Ступенчатый массив - {t_3}");
        }
    }
}
