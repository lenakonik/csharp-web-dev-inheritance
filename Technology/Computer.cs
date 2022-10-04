using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    internal class Computer : AbstractEntity
    {
        public double Ram { get; set; }
        public double Storage { get; set; }
        public readonly bool hasKeyboard;

        public Computer(double ram, double storage, bool keyboard): base()
        {
            Ram = ram;
            Storage = storage;
            hasKeyboard = keyboard;
        }

        public void IncreaseRam(double added_ram)
        {
            Ram += added_ram;
        }

        public void IncreaseStorage(double added_storage)
        {
            Storage += added_storage;
        }
    }

}
