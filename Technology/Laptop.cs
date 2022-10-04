using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    internal class Laptop : Computer
    {
        public double Weight { get; set; }

        public Laptop(double ram, double storage, bool keyboard, double weight) : base(ram, storage, keyboard)
        {
            Weight = weight;
        }

        public bool isHeavy()
        {
            return Weight > 5;
        }
    }
}
