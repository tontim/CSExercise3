using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3
{
    //"Blueprint"
    public class PersonHandler 
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(string Fname, string Lname, int Age, double Height, double Weight)
        {
            return new Person(Fname, Lname, Age, Height, Weight);
        }


    }
}
