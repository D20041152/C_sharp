using System;

namespace laba_1
{
    internal class Student
    {

        public Student(in Person pers, Education education, int number_group)
        {
            this.pers = pers;
            this.education = education;
            this.number_group = number_group;
            exams = new Exam[0];
            exams_3 = new Exam[0][];
        }

        public Student()
        {
            pers = new Person();
            education = new Education();
            number_group = 0;
            exams = new Exam[0];
            exams_3 = new Exam[0][];
        }

        public int PERSON { get; set; }
        public int EDUCATION { get; set; }
        public int NUMBER_group { get; set; }

        public string get_exam()
        {
            string res = "";
            if (exams.Length > 0)
            {
                
                foreach (var exam in exams)
                {
                    res += Convert.ToString(exam) + "\n";
                };

       
            }

            else if(exams_3.Length > 0)
            {
                for (int i = 0; i < exams_3.Length; i++)
                {
                    for (int j = 0; j < exams_3[i].Length; j++)
                    {
                        res += Convert.ToString(exams_3[i][j]) + "\n";
                    }
                }
            }
            return res;
        } 

       
        public void index()
        {
            foreach (Education value in Enum.GetValues(typeof(Education)))
            {
                Console.WriteLine($"{value} -> {(int)value}");
            }
            Console.WriteLine();
        }

        public double average()
        {
            int sum = 0, n = 0;
            foreach (var exam in exams)
            {
                sum += exam.mark;
                n++;
            }
            return (double)sum / n;
        }

        public void AddExams(in Exam[] other_exams)
        {
            int size_exams = exams.Length;
            Array.Resize(ref exams, other_exams.Length);
            for (int i = size_exams; i < other_exams.Length; i++)
            {
                exams[i] = other_exams[i - size_exams];
            }
        }

        public void AddExams(in Exam[,] other_exams)
        {
            int n = 0;
            int size_exams = exams.Length;
            Array.Resize(ref exams, other_exams.Length);
            for (int i = size_exams; i < other_exams.GetLength(0); i++)
            {
                for (int j = size_exams; j < other_exams.GetLength(1); j++)
                {
                    exams[n + j] = other_exams[i - size_exams, j - size_exams];
                }
                n = n + other_exams.GetLength(1);
            }
        }

        public void AddExams(in Exam[][] other_exams)
        {
            int size_exams = exams_3.Length;
            Array.Resize(ref exams_3, other_exams.Length);
            for (int i = size_exams; i < exams_3.Length; i++)
            {
                exams_3[i] = other_exams[i - size_exams];
            }

        }


        public override string ToString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + "\nЭкзамены:\n" + Convert.ToString(get_exam());
        }

        public virtual string ToShortString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + " " + Convert.ToString(average());

        }


        private Person pers;
        private Education education;
        private int number_group;
        private Exam[] exams;
        private Exam[][] exams_3;
    }
}
