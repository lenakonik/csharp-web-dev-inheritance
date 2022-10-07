using System;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleChoice mq = new MultipleChoice("What's the time?", "12am, 12pm, 3pm", "3pm");
            Checkbox ch = new Checkbox("What's the time?", "12am, 12pm, 3pm", "3pm");

            ch.PrintQuestion();
            ch.PrintAnswerOptions();
        }
    }
}
