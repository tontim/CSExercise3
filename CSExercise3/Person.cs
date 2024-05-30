using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3
{
        public class Person
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Age { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }


            //Constructor
            public Person(string firstName, string lastName, int age, double height, double weight)
            {
            this.FName = firstName;
            this.LName = lastName;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            ////First name kollen
            //if (Utility.StringWithin2and10(firstName))
            //{
            //    this.FName = firstName;
            //}
            //else
            //{
            //    throw new ArgumentException("Namnet är inte inom 2 och 10.");
            //}

            ////Last name kollen
            //if (Utility.StringWithin3and15(lastName))
            //{
            //    this.LName = lastName;
            //}
            //else
            //{
            //    throw new ArgumentException("Namnet är inte inom 3 och 15.");
            //}

            ////Age kollen 
            //if (Utility.IsGreaterThanZero(age))
            //{
            //    this.Age = age;
            //}
            //else
            //{
            //    throw new ArgumentException("Åldern är 0 eller mindre.");
            //}

        }
        }
}
