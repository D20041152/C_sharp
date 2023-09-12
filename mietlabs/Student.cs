using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mietlabs
{
    internal class Student
    {
        public Student(Person pers, Education education, int number_group)
        {
            this.pers = pers;
            this.education = education;
            this.number_group = number_group;
            exams = new Exam[] { new Exam() };
        }

        public Student()
        {
            pers = new Person();
            education = new Education();
            number_group = 0;
            exams = new Exam[] { new Exam() };
        }

        public Person get_person()
        {
            return pers;
        }

        public Education get_education()
        {
            return education;
        }

        public int get_number_group()
        {
            return number_group;
        }

        public string get_exam()
        {
            string res = "";
            foreach (var exam in exams)
            {
                res += Convert.ToString(exam) + "\n";
            };
            return res;
        }

        public void set_person(Person pers)
        {
            this.pers = pers;
        }

        public void set_education(Education education)
        {
            this.education = education;
        }

        public void set_number_group(int number_group)
        {
            this.number_group = number_group;
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

        public void AddExams(Exam[] other_exams)
        {
            int size_exams = exams.Length;
            Array.Resize(ref exams, other_exams.Length);
            for (int i = size_exams - 1; i < other_exams.Length; i++)
            {
                exams[i] = other_exams[i - size_exams + 1];
            }
        }

        public override string ToString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + " " + Convert.ToString(get_exam());
        }

        public virtual string ToShortString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + " " + Convert.ToString(average());

        }


        private Person pers;
        private Education education;
        private int number_group;
        private Exam[] exams;
}
}
