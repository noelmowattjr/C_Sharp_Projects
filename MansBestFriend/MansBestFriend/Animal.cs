using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansBestFriend
{
    class Animal
    {
        //--Animal member fields
        private string Typee;
        private int Age;
        private string Name;
        private char Gender;

        //--Animal Constructor
        public Animal(string typee, int age, string name, char gender)
        {
            Typee = typee; Age = age; Name = name; Gender = gender;
        }

        //------Getters - Setters-------------//
        public string Type_Animal_GS
        {
            get { return Typee; }
            set { Typee = value; }
        }

        public int Age_GS
        {
            get { return Age; }
            set { Age = value; }
        }

        public string Name_GS
        {
            get { return Name; }
            set { Name = value; }
        }

        public char Gender_GS
        {
            get { return Gender; }
            set { Gender = value; }
        }
    }
}
