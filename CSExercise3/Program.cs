namespace CSExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PersonHandler person1 = new();

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
        }
    }
}

