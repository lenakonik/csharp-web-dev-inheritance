using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    internal class Checkbox : Question
    {
        public string[] Answer { get; set; }

        public Checkbox(string qtext, string options, string answers) : base(qtext, options)
        {
            // Create an array of answer options
            answers = answers.Replace(" ", string.Empty);
            Answer = answers.Split(',');
        }

        public override void CheckAnswer()
        {

        }


    }
}
