using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercise3
{
    abstract class Animal
    {
        //Om samtliga djur behöver ett nytt attribut måste vi lägga till det här
        public string Name { get; set; } = string.Empty;
        public int Age {  get; set; }
        public double Weight { get; set; }
        public abstract void DoSound();

        //Och även här + när vi gör konstruktorn för djuren
        public Animal(string name, int age, double weight )
        {
            this.Name = name;
            this.Age = age; 
            this.Weight = weight;
            this.DoSound();
        }
        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }
    }
    class Horse : Animal
    {
        public bool Trample { get; set; }
        public Horse(string name, int age, double weight) : base(name, age, weight)
        {
            this.Trample = true;
        }
        public override void DoSound()
        {
            Console.WriteLine("Horse says: Hello sir!");
        }
        public override string Stats()
        {
            return base.Stats() + $", Trample: {Trample}";
        }
    }
    class Dog : Animal
    {
        public int SuperSpeed { get; set; }
        public Dog(string name, int age, double weight) : base(name, age, weight)
        {
            this.SuperSpeed += 20;
        }
        public override void DoSound()
        {
            Console.WriteLine("Dog says: Yeah?");
        }
    }
    class Hedgehog : Animal
    {
        public bool Spikes { get; set; }
        public Hedgehog(string name, int age, double weight) : base(name, age, weight)
        {
            this.Spikes = true;
        }
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog says: Yeees?");
        }
    }
    class Worm : Animal
    {
        public int SlowSpeed { get; set; }
        public Worm(string name, int age, double weight) : base(name, age, weight)
        {
            this.SlowSpeed = 2;
        }
        public override void DoSound()
        {
            Console.WriteLine("Worm says: Uhoh.");
        }
    }
    class Bird : Animal
    {
        //Om samtliga fåglar behöver nya attribut måste vi skapa dem här
        //T.ex public bool CanFly...
        public bool HasWings {  get; set; }
        public Bird(string name, int age, double weight) : base(name, age, weight)
        {
            this.HasWings = true;
            //this.CanFly...
        }
        public override void DoSound()
        {
            Console.WriteLine("Bird says: ...");
        }
    }
    class Pelican : Bird
    {
        public int ExtraWeight { get; set; }
        //Även de andra fåglarna måste ha med "CanFly" i sin konstruktor
        public Pelican(string name, int age, double weight) : base(name, age, weight)
        {
            this.ExtraWeight += 10;
        }
    }
    class Flamingo : Bird
    {
        public bool SpecialColor { get; set; }
        public Flamingo(string name, int age, double weight) : base(name, age, weight)
        {
            this.SpecialColor = true;
        }
    }
    class Swan : Bird
    {
        public int LongWings { get; set; }
        public Swan(string name, int age, double weight) : base(name, age, weight)
        {
            this.LongWings += 5;
        }
    }
    class Wolf : Animal
    {
        public int PlusAttack { get; set; }
        public Wolf(string name, int age, double weight) : base(name, age, weight)
        {
            this.PlusAttack += 10;
        }
        public override void DoSound()
        {
            Console.WriteLine("Horse says: Hehe.");
        }
    }
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public void Talk()
        {
            Console.WriteLine("Wolfman says: Well well well..");
        }
        
    }
}
