using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3
{
    //"Blueprint"
    internal class PersonHandler 
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int Age, string Fname, string Lname, double Height, double Weight)
        {
            return new Person(Fname, Lname, Height, Weight);
        }


    }
}
