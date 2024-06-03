using System;
using System.Collections.Generic;
using CSExercise3.UserError;

namespace CSExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animals listan som måste vara av typen "Animal"
            annars kommer det bli mismatch */

            var animals = new List<Animal>();
            var horse = new Horse("Horsey", 5, 500);
            var dog = new Dog("Doggey", 3, 30);
            var wolfman = new Wolfman("Wolfeymaney", 500, 100);
            animals.Add(horse);
            animals.Add(dog);
            animals.Add(wolfman);

            /* För varje item i animals kommer funktionen stats skrivas ut
             som skrevs i Animal.cs, och sen kollar vi även om IPerson används
            och då kommer vi använda oss av Talk() funktionen i IPerson*/
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
                if (animal is IPerson person)
                {
                    person.Talk();
                }
                /*För att komma åt superspeed för dog måste vi
                anropa metoden inuti Dog, 
                Animal listan känner inte till vad som finns i Dog */
                else if (animal is Dog dogg)
                {
                    Console.WriteLine("Superspeed addition: " + dogg.SuperSpeed);
                }
            }

            //Lista för User errors
            var errors = new List<UserError.UserError>();

            var numericError = new NumericInputError();
            var textError = new TextInputError();
            var nullError = new NullInputError();
            var longError = new LongInputError();
            var shortError = new ShortInputError();

            errors.Add(numericError);
            errors.Add(textError);
            errors.Add(nullError);
            errors.Add(longError);
            errors.Add(shortError);

            Console.WriteLine("Här följer alla usererrors:");
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }

            //Går igenom person och personhandler logiken
            try
            {
                Console.WriteLine("Testar ny person klass.");
                PersonHandler personhandler = new();
                Person person1 = personhandler.CreatePerson("Kalle", "Kuling", 30, 30, 30);
                Person person2 = personhandler.CreatePerson("Britt-Marie", "Strandö", 40, 55, 55);
                //Person person3 = personhandler.CreatePerson("F", "Mångafelpådennapersonenojojoj", 78888, 3000, 5000);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett FEL har inträffat! Felkod: {ex.Message}");
                throw new ArgumentException("Felaktigheter med input.", ex);
            }
            Console.WriteLine("Gick bra.");
            Console.ReadLine();
        }

    }
}

