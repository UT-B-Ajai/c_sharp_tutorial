using System;

namespace Learning_c_sharp
{
    public class Encapsulation
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static void EncapsulationExample()
        {
            Encapsulation person = new Encapsulation();
            person.Name = "John Doe"; 
            Console.WriteLine($"Name is: {person.Name}");
        }
    }
}
