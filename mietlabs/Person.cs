using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mietlabs
{
    internal class Person
    {
        public Person(string name, string surname, DateTime dt)
        {
            this.name = name;
            this.surname = surname;
            this.dt = dt;
        }

        public Person()
        {
            this.name = "";
            this.surname = "";
            this.dt = new DateTime(1978, 1, 1);
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
            return dt;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setDate(System.DateTime dt)
        {
            this.dt = dt;
        }

        public override string ToString()
        {
            return Convert.ToString(name) + " " + Convert.ToString(surname) + " " + Convert.ToString(dt);
        }

        public virtual string ToShortString()
        {
            return Convert.ToString(name) + " " + Convert.ToString(surname);
        }


        private string name;
        private string surname;
        private System.DateTime dt;

    }
}
