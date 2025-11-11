using System;

public class Dog : Animal
{
	private string breed;
	private int toysEviserated;
	public Dog(string breed, int toysmurdered, string name, int age) : base(name, age)
	{
		this.breed = breed;
		this.toysEviserated = toysmurdered;
	}
	public override void Speak()
	{
		Console.WriteLine("wof");
	}
}
