using System.Collections;
using System;
using System.Runtime.Remoting;
using System.Diagnostics.Tracing;

namespace laba_2
{
    internal class Student : Person, IDateAndCopy
    {

        public Student(Person pers, Education education, int number_group)
        {
            this.pers = pers;
            this.education = education;
            this.NUMBER_group = number_group;
            exams = new ArrayList(0);
            tests = new ArrayList(0);

        }

        public Student()
        {
            Person pers = new Person();
            education = new Education();
            number_group = 0;
            exams = new ArrayList(0);
            tests = new ArrayList(0);

        }

        public void AddExams(params Exam[] other_exams)
        {
            foreach (var item in other_exams)
            {
                exams.Add(item);
            }

        }

        public void AddTests(params Test[] other_tests)
        {
            foreach (var item in other_tests)
            {
                tests.Add(item);
            }

        }

        private String ToExam()
        {
            string res = "";
            foreach (var exam in exams)
            {
                res += Convert.ToString(exam) + "\n";
            }

            return res;
        }

        private String ToTest()
        {
            string res = "";
            foreach (var test in tests)
            {
                res += Convert.ToString(test) + "\n";
            }

            return res;
        }

        public override string ToString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + "\nЭкзамены и зачёты:\n" + Convert.ToString(ToExam()) + Convert.ToString(ToTest());
        }

        public override string ToShortString()
        {
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + " " + Convert.ToString(average);

        }

        public override object DeepCopy()
        {
            Student obj_copy = new Student();
            obj_copy.pers = pers.DeepCopy() as Person;
            obj_copy.education = education;
            obj_copy.number_group = number_group;
            foreach (var exem in exams)
            {
                obj_copy.exams.Add(exem);
            }

            foreach (var test in tests)
            {
                obj_copy.tests.Add(test);
            }
            return obj_copy;
        }

        public IEnumerable iter_exam(int mark)
        {
            foreach (Exam exam in exams)
            {
                if (exam.mark > mark)
                {
                    yield return exam;
                }
            }
        }

        public IEnumerable iter_testexam()
        {
            foreach (Exam exam in exams)
            {
                yield return exam;
            }

            foreach (Test test in tests)
            {
                yield return test;
            }
        }

        public double average
        {
            get
            {
                int sum = 0, n = 0;
                foreach (Exam exam in exams)
                {
                    sum = sum + exam.mark;
                    n++;
                }
                return (double)sum / n;
            }
        }
        public System.Collections.ArrayList EXAMS
        {
            get
            {
               return exams;
            }

            set
            {
                exams.Add(value);
            }
        }

        public System.Collections.ArrayList TESTS
        {
            get
            {
                return tests;
            }

            set
            {
                tests.Add(value);
            }
        }

        public int NUMBER_group
        {
            get { return number_group; }

            set
            {
                try
                {

                    if (value <= 100 || value > 599)
                    {
                        throw new AccessViolationException("Ошибка! Допустимые границы номера группы - от 101 до 599");
                    }
                    else
                    {
                        number_group = value;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public bool this[Education ed]

        {
            get
            {
                return ed == education;
            }
        }

        public Person person
        {
            get
            {
                return pers;
            }

            set
            {
                name = value.NAME;
                surname = value.SURNAME;
                Date = value.Date;
            }


        }


        private Person pers;
        private Education education;
        private int number_group;
        private ArrayList tests;
        private ArrayList exams;
    }
}
