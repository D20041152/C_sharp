using System;
using System.Security.Cryptography;

namespace laba_3
{
    internal class Exam : IDateAndCopy, System.IComparable<Exam>, System.Collections.Generic.IComparer<Exam>
    {

        public Exam(string name_sub, int mark, System.DateTime date_exam)
        {
            this.name_sub = name_sub;
            this.mark = mark;
            Date = date_exam;
        }

        public Exam()
        {
            name_sub = "None";
            mark = 0;
            Date = new DateTime(1978, 1, 1);
        }

        public int CompareTo(Exam ex)
        {
            return this.name_sub.CompareTo(ex.name_sub);
        }

        public int Compare(Exam ex1, Exam ex2)
        {
            return ex1.mark - ex2.mark;
        }
        public override string ToString()
        {
            return $"{Convert.ToString(name_sub),-15}\t{Convert.ToString(mark)}\t{Convert.ToString(Date)} ";
        }

        public object DeepCopy()
        {
            Exam obj_copy = new Exam();
            obj_copy.name_sub = name_sub;
            obj_copy.mark = mark;
            obj_copy.Date = Date;

            return obj_copy;
        }

        public string name_sub { get; set; }
        public int mark { get; set; }
        public System.DateTime Date { get; set; }
    }
}
