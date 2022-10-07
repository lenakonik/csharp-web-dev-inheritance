using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public string[] AnswerOptions { get; set; }

        public Question(string qtext)
        {
            QuestionText = qtext;

        }

        public Question(string qtext, string options) : this(qtext)
        {
            // Create an array of answer options
            options = options.Replace(" ", string.Empty);
            AnswerOptions = options.Split(',');
        }

        public void PrintQuestion()
        {
            Console.WriteLine(QuestionText);
        }


        public void PrintAnswerOptions()
        {
            string options = String.Join(", ", AnswerOptions);
            Console.Write("Answer options: " + options);
        }

        public abstract void CheckAnswer();
    }
}
