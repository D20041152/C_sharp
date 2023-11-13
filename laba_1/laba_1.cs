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

        static double timer(Exam[] ex, int nrow, int ncol)
        {
            Stopwatch stopWatch_1 = new Stopwatch();
            stopWatch_1.Start();
            for (int i = 0; i < nrow * ncol; i++)
            {
                Console.WriteLine(ex[i].ToString());
            }
            Console.WriteLine();
            
            stopWatch_1.Stop();
            return stopWatch_1.Elapsed.TotalSeconds;
        }

        static double timer(Exam[,] ex, int nrow, int ncol)
        {
            Stopwatch stopWatch_1 = new Stopwatch();
            stopWatch_1.Start();
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    Console.WriteLine(ex[i, j].ToString());
                }
            }
            Console.WriteLine();
            stopWatch_1.Stop();
            return stopWatch_1.Elapsed.TotalSeconds;
        }

        static double timer(Exam[][] ex, int nrow, int ncol)
        {
            Stopwatch stopWatch_1 = new Stopwatch();
            stopWatch_1.Start();
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    Console.WriteLine(ex[i][j].ToString());
                }
            }
            Console.WriteLine();
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

            double t_1 = timer(ex, nrow, ncol);

            Exam[,] ex_2 = new Exam[nrow, ncol];

            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    ex_2[i, j] = new Exam();
                }
            }
            Student student_2 = new Student(pers, Education.Bachelor, 2);
            
            double t_2 = timer(ex_2, nrow, ncol);


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
            double t_3 = timer(ex_3, nrow, ncol);

            Console.WriteLine($"Одномерный массив - {t_1}");
            Console.WriteLine($"Прямоугольный массив - {t_2}");
            Console.WriteLine($"Ступенчатый массив - {t_3}");
        }
    }
}
