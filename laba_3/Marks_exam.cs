using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    internal class Marks_exam : IComparer<Exam>
    {
        public int Compare(Exam x, Exam y)
        {
            return x.mark.CompareTo(y.mark);
        }
    }
}
