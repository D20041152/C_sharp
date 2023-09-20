using System;

namespace mietlabs
{
    internal class Person
    {
        public Person(string name, string surname, DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public Person()
        {
            this.name = "None";
            this.surname = "None";
            this.birthday = new DateTime(1978, 1, 1);
        }

        public int NAME { get; set; }
        public int SURNAME { get; set; }
        public int DATETIME { get; set; }

        public override string ToString()
        {
            return Convert.ToString(name) + " " + Convert.ToString(surname) + " " + Convert.ToString(birthday);
        }

        public virtual string ToShortString()
        {
            return Convert.ToString(name) + " " + Convert.ToString(surname);
        }


        private string name;
        private string surname;
        private System.DateTime birthday;

    }
}
