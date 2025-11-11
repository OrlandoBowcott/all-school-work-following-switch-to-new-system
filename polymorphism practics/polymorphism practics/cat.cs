using System;

public class Cat : Animal
{
	private string breed;
	private int evilnessFactor;

	public Cat(string breed, int evilnessfactor, string name, int age) : base(name,age)
	{
		this.breed = breed;
		this.evilnessFactor = evilnessfactor;
    }
	public override void Speak()
	{
		Console.WriteLine("Meow Meow");
    }
}
