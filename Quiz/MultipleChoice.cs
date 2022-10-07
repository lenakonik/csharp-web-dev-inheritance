using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    internal class MultipleChoice : Question
    {
        public string Answer { get; set; }

        public MultipleChoice(string qtext, string options, string ans) : base(qtext, options) 
        {
            Answer = ans;
        }


        public override void CheckAnswer()
        {

        }

    }
}
