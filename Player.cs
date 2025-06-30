using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Player
    {
        string name;
        string country;
        int age;
        DateTime doj;
        public string Name
        { get { return name; } set { name = value; } }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int Age { get { return age; } set { age = value; } }

        public DateTime Doj { get { return doj; } set { doj = value; } }

        public Player() { }

        public Player(string name, string country, int age, DateTime doj)
        {
            this.name = name;
            this.country = country;
            this.age = age;
            this.doj = doj;
        }

        public override string ToString()
        {
            return "Name-" + Name + ",Country-" + Country + ",Age-" + Age;
        }

        public bool Equals(Player p)
        {
            if (this.name.ToLower() == p.Name.ToLower() & this.country.ToLower() == p.country.ToLower())
                return true;
            else
                return false;
        }
    }
}

the above code is written by Tester T1.

    the next code is added by tester T2.
