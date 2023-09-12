using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mietlabs
{
    internal class Exam
    {
        public Exam(string name_sub, int mark, System.DateTime date_exam)
        {
            this.name_sub = name_sub;
            this.mark = mark;
            this.date_exam = date_exam;
        }

        public Exam()
        {
            name_sub = "";
            mark = 0;
            date_exam = new DateTime(1978, 1, 1);
        }
        public override string ToString()
        {
            return Convert.ToString(name_sub) + " " + Convert.ToString(mark) + " " + Convert.ToString(date_exam);
        }

        public string name_sub;
        public int mark;
        public System.DateTime date_exam;

    }
}
