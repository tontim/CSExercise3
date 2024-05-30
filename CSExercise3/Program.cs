namespace CSExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ny person, namn, förnamn, ålder, längd och vikt
            PersonHandler person1 = new("Kalle", "Kuling", 23, 175.3, 89.43);
        }

        //try
        //{
        //    Console.WriteLine("Testing new person class.");
        //    PersonHandler person = new Person("Kalle", "Kuling", 2, 128, 99);
        //}
        //catch (Exception)
        //{
        //    throw new ArgumentException("Input incorrect.");
        //}


        //public class Person
        //{
        //public string FName { get; set; }
        //public string LName { get; set; }
        //public int Age { get; set; }
        //public double Height { get; set; }
        //public double Weight { get; set; }


        // //Constructor
        // public Person(string firstName, string lastName, int age, double height, double weight)
        // {
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
        //this.Height = height;
        //this.Weight = weight;
        //}

    }
}

