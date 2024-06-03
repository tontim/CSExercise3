using System;
using System.Collections.Generic;
using CSExercise3.UserError;

namespace CSExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadLine();
        }

    }
}

