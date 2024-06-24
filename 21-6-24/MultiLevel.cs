using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Mammal : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Mammal makes a sound");
    }
}

class Dog : Mammal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Sound();

        Mammal mammal = new Mammal();
        mammal.Sound();

        Animal animal = new Animal();
        animal.Sound();
    }
}
