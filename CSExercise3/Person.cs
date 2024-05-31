using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3
{
    //"Person Blueprint"
    public class Person
    {
        //Undvika null varningar så sätter string till empty
        public string Fname { get; set; } = string.Empty;
        public string Lname { get; set; } = string.Empty;
        public int Age;
        public double Height;
        public double Weight;

        //Constructor
        public Person(string fname, string lname, int age, double height, double weight)
        {
            this.fname = fname ?? throw new ArgumentNullException(nameof(fname));
            this.lname = lname ?? throw new ArgumentNullException(nameof(lname));
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public string fname
        {
            get { return Fname; }
            set
            {
                //First name kollen
                if (Utility.StringWithin2and10(fname))
                {
                    this.Fname = fname;
                }
                else
                {
                    throw new ArgumentException("Namnet är inte inom 2 och 10.");
                }
            }
        }
        //Last name kollen
        public string lname
        {
            get { return Fname; }
            set
            {
                if (Utility.StringWithin3and15(lname))
                {
                    this.Lname = lname;
                }
                else
                {
                    throw new ArgumentException("Namnet är inte inom 3 och 15.");
                }

            }
        }

        //Age kollen 
        public int age
        {
            get { return Age; }
            set
            {
                if (Utility.IsGreaterThanZero(age))
                {
                    this.Age = age;
                }
                else
                {
                    throw new ArgumentException("Åldern är 0 eller mindre.");
                }
            }
        }
        public double height
        {
            get { return Height; }
            set
            {
                if (Utility.IsWithinRange(height, 22, 300))
                {
                    Height = height;
                }
                else
                {
                    throw new ArgumentException("Inte inom 22 och 300.");
                }
            }
        }
        public double weight
        {
            get { return Weight; }
            set
            {
                if (Utility.IsWithinRange(weight, 2, 1000))
                {
                    Weight = weight;
                }
                else
                {
                    throw new ArgumentException("Inte inom 2 och 1000.");
                }
            }
        }
    }
}

