using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class Test
    {
        Test(string name_subject, bool test_is_passed)
        {
            this.name_subject = name_subject;
            this.test_is_passed = test_is_passed;
        }
        Test()
        {
            name_subject = "";
            test_is_passed = false;
        }

        public override string ToString()
        {
            return name_subject + Convert.ToString(test_is_passed);
        }

        public string NAME_subject { get; set; }
        public bool TEST_is_passed { get; set; }

        private string name_subject;
        private bool test_is_passed;

    }
}
