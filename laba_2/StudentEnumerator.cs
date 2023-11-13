/* using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class StudentEnumerator: IEnumerable
    {
        public StudentEnumerator(ArrayList exams, ArrayList tests)
        {
            this.exams = exams;
            this.tests = tests;
        }

        public IEnumerator GetEnumerator() => exams.GetEnumerator();
     

        var result = System.Linq.Enumerable.Intersect(exams.ToArray(), test.ToArray());

        private ArrayList exams;
        private ArrayList tests;   
    }
}
*/
