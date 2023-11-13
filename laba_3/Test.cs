using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    internal class Test
    {
        public Test(string name_subject, bool test_is_passed)
        {
            this.name_subject = name_subject;
            this.test_is_passed = test_is_passed;
        }

        public Test()
        {
            name_subject = "None";
            test_is_passed = false;
        }

        public override string ToString()
        {
            return name_subject + "\t\t" + Convert.ToString(test_is_passed);
        }

        public string name_subject { get; set; }
        public bool test_is_passed { get; set; }


    }
}
