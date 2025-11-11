namespace polymorphism_tasks
{
    using System;


    public abstract class Animal

    {

        public abstract void Speak();

    }


    public class Dog : Animal

    {

        public override void Speak()

        {

            Console.WriteLine("Dog barks");

        }

    }


    public class Cat : Animal

    {

        public override void Speak()

        {

            Console.WriteLine("Cat meows");

        }

    }


    class Program

    {

        static void Main(string[] args)

        {

            Animal myAnimal = new Animal();

            Animal myDog = new Dog();

            Animal myCat = new Cat();


            myAnimal.Speak(); // What will this output?

            myDog.Speak(); // What will this output?

            myCat.Speak(); // What will this output?

        }

    }
}
