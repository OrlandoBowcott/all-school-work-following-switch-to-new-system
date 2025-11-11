namespace polymorphism_practics
{
    internal class Program
    {
        static void Main()
        {

            var bob = new Cat("Siamese", 3, "bob", 2);
            var jeff = new Dog("Labrador", 5, "jeff", 4);

            bob.Speak();
            jeff.Speak();
        }
    }
}
