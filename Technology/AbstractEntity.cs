using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        private static int nextId = 1;
        public int Id { get; set; }

        public AbstractEntity()
        {
            Id = nextId;
            nextId ++;
        }
    }
}
