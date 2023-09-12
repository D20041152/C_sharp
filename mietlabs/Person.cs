using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public System.DateTime getDate()
        {
            return birthday;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setDate(System.DateTime birthday)
        {
            this.birthday = birthday;
        }

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
