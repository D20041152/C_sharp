using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    delegate TKey KeySelector <TKey>(Student st);
    internal class StudentCollection<TKey>
    {
        public StudentCollection(KeySelector<TKey> keySelector)
        {
            this.keySelector = keySelector;
            student_dict = new Dictionary<TKey, Student>();
        }

        public double MaxAvgMark
        {
            get
            {
                if(student_dict.Count <= 0) { return -1;}

                return student_dict.Values.Max(pr => pr.average);
            }
        }

        public IEnumerable<IGrouping<Education, KeyValuePair<TKey, Student>>> GroupEducation
        {
            get
            {
                return student_dict.GroupBy(student => student.Value.education);
            }
        }

        public IEnumerable<KeyValuePair<TKey, Student>> EducationForm(Education value)
        {
            return student_dict.Where(student => student.Value.education == value);
        }

        public void AddDefaults(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Student student = new Student(new Person("name" + i.ToString(), "surname" + i.ToString(), new DateTime(1901, 12, 12)), Education.SecondEducation, 119);
                student_dict.Add(keySelector(student), student);
            }
        }

        public void AddStudents(params Student[] students)
        {
            foreach (var student in students)
            {
                student_dict.Add(keySelector(student), student);
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < student_dict.Count; i++)
            {
                result += student_dict.Values.ElementAt(i).ToString();
            }
            return result;
        }

        public string ToShortString()
        {
            string result = "";
            for (int i = 0; i < student_dict.Count; i++)
            {
                result += student_dict.Values.ElementAt(i).ToShortString();
            }
            return result;
        }



        private Dictionary<TKey, Student> student_dict;
        private KeySelector<TKey> keySelector;
    }
}
