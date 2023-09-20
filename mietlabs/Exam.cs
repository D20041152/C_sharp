using System;


namespace laba_1
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
            name_sub = "None";
            mark = 0;
            date_exam = new DateTime(1978, 1, 1);
        }
        public override string ToString()
        {
            return $"{Convert.ToString(name_sub),-15}\t{Convert.ToString(mark)}\t{Convert.ToString(date_exam)} ";
        }

        public string name_sub;
        public int mark;
        public System.DateTime date_exam;

    }
}
