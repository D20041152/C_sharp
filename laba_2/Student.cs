using System;

namespace laba_2
{
    internal class Student : Person, IDateAndCopy
    {
        private Education ed;
        private int number_group;
        private System.Collections.ArrayList tests;
        private System.Collections.ArrayList exams;
    }
}
