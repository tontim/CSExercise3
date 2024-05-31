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

            }
            catch (Exception)
            {
                throw new ArgumentException("Fel input.");
            }
        }
    }
}

