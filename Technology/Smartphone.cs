using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    internal class Smartphone : Computer
    {
        public int numberOfSelphies = 0;

        public Smartphone(double ram, double storage, bool keyboard) : base(ram, storage, keyboard){}

        public void MakeSelphie()
        {
            numberOfSelphies += 1;
        }


    }
}
