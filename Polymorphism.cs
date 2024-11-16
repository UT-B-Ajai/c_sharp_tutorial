using System;

namespace Learning_c_sharp
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    public class Polymorphism
    {
        public static void PolymorphismExample()
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.Speak(); 
            myCat.Speak(); 
        }
    }
}
