using laba_3;
using System;
using System.Security.Policy;
using System.Text;

namespace laba_3
{
    internal class Person : IDateAndCopy
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
        public string NAME
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }
        public string SURNAME
        {
            get
            {
                return surname;
            }

            set
            {
                this.surname = value;
            }
        }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Convert.ToString(name) + " " + Convert.ToString(surname) + " " + Convert.ToString(birthday);
        }

        public virtual string ToShortString()
        {
            return Convert.ToString(name) + " " + Convert.ToString(surname);
        }

        public static bool operator ==(in Person a, in Person b)
        {
            return a.name == b.name && a.surname == b.surname && a.birthday == b.birthday;
        }

        public static bool operator !=(in Person a, in Person b)
        {
            return !(a.name == b.name && a.surname == b.surname && a.birthday == b.birthday);
        }

        public override bool Equals(object obj)
        {
            Person pers = (Person)obj;
            return this == pers;
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode() + this.surname.GetHashCode() + this.birthday.GetHashCode();
        }

        public virtual object DeepCopy()
        {
            Person obj_copy = new Person();
            obj_copy.name = this.name;
            obj_copy.surname = this.surname;
            obj_copy.birthday = this.birthday;
            return obj_copy;
        }


        protected string name;
        protected string surname;
        protected System.DateTime birthday;

    }
}
