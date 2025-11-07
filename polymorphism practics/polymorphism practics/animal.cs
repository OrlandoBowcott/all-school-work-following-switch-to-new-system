using System;

public abstract class Animal
{
	private string name;
	private int age;
	public Animal(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	public abstract void Speak();

	public void PrintDetails()
	{
		Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
