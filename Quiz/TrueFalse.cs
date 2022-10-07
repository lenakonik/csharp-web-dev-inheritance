using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    internal class TrueFalse : Question
    {
        public bool Answer { get; set; }

        public TrueFalse(string qtext) : base (qtext)
        {
            
        }


        public override void CheckAnswer()
        {

        }

    }
}
