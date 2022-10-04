using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";

        // : means extend the base class constructor 
        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // if there is a base no-arg constructor, it will be called implicitly
        public HouseCat(string name)
        {
            Name = name;
        }

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        // When overriding a method from a base class, the method name, access level, type and number of parameters, and return type must be exactly the same.
        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return base.Noise(); // prints "Meow!" - call the method from the base class that we are overriding 
            }
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
