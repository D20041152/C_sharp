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
        }

        public Student()
        {
            pers = new Person();
            education = new Education();
            number_group = 0;
            exams = new Exam[0];
        }

        public int PERSON { get; set; }
        public int EDUCATION { get; set; }
        public int NUMBER_group { get; set; }


        public string get_exam()
        {
            string res = "";
                
             foreach (var exam in exams)
             {
                res += Convert.ToString(exam) + "\n";
             };

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

        public bool this[Education ed]

        { 
            get
            {
                return ed == education;
            }
        }
        public double average
        {
            get
            {
                int sum = 0, n = 0;
                foreach (var exam in exams)
                {
                    sum += exam.mark;
                    n++;
                }
                return (double)sum / n;
            }
        }


        public void AddExams(params Exam[] other_exams)
        {
            int size_exams = exams.Length;
            Array.Resize(ref exams, other_exams.Length);
            for (int i = size_exams; i < other_exams.Length; i++)
            {
                exams[i] = other_exams[i - size_exams];
            }
        }



        public override string ToString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + "\nЭкзамены:\n" + Convert.ToString(get_exam());
        }

        public virtual string ToShortString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + " " + Convert.ToString(average);

        }
            

        private Person pers;
        private Education education;
        private int number_group;
        private Exam[] exams;
    }
}
