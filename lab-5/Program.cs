namespace lab_5;

// Step 1 - Create a Base Class
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 - Create Derived Classes
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 3 - Test in Main()
        Animal animal = new Animal();
        Animal cat = new Cat();
        Animal dog = new Dog();

        animal.animalSound();
        cat.animalSound();
        dog.animalSound();
    }
}
