using System.Collections.Generic;
using System.Collections;
using System;
using System.Runtime.Remoting;
using System.Diagnostics.Tracing;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace laba_3
{
    internal class Student : Person, IDateAndCopy
    {

        public Student(Person pers, Education education, int number_group)
        {
            this.pers = pers;
            this.education = education;
            this.NUMBER_group = number_group;
            exams = new List <Exam>(0);
            tests = new List <Test>(0);

        }

        public Student()
        {
            Person pers = new Person();
            education = new Education();
            number_group = 0;
            exams = new List <Exam>(0);
            tests = new List <Test>(0);

        }

        public void sort_name_sub()
        {
            exams.Sort();
        }

        public void sort_mark()
        {
            exams.Sort(new Marks_exam());
        }

        public void sort_date() 
        {
            exams.Sort(new Date_exam());
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
            return Convert.ToString(pers) + " " + Convert.ToString(education) + " " + Convert.ToString(number_group) + "\nЭкзамены и зачёты:\n" + Convert.ToString(ToExam()) + Convert.ToString(ToTest()) + "\n";
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

        public IEnumerable getDoneTestsandExam()
        {
            foreach (Exam exam in exams)
            {
                if (exam.mark > 2)
                {
                    yield return exam;
                }
            }

            foreach (Test test in tests)
            {
                if (test.test_is_passed) yield return test;
            }
        }

        public IEnumerable getDoneTest()
        {
            foreach (Test test in tests)
            {
                foreach (Exam exam in exams)
                {
                    if (test.test_is_passed && exam.mark > 2 && test.name_subject == exam.name_sub) yield return test;
                }
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
        public List<Exam> EXAMS
        {
            get
            {
                return (List<Exam>)exams;
            }

            set
            {
                exams = value as List<Exam>;
            }
        }

        public List<Test> TESTS
        {
            get
            {
                return tests;
            }

            set
            {
                tests = value as List<Test>;
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

        public override int GetHashCode()
        {
            return pers.NAME.GetHashCode() + pers.SURNAME.GetHashCode();
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
        public Education education;
        private int number_group;
        private List<Test> tests;
        private List<Exam> exams;

    }
}
