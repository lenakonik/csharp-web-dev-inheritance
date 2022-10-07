using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz;
using System.Collections.Generic;

namespace QuizTest
{
    [TestClass]
    public class QuizTest

    {
        MultipleChoice mq = new MultipleChoice("What's the time?", "12am, 12pm, 3pm", "3pm");
        Checkbox ch = new Checkbox("Which types of tests exist?", "func, perf, auro", "func, perf");

        [TestMethod]
        public void CheckMultipleChoiceConstructor()
        {
            // Question text is correct
            Assert.IsTrue(mq.QuestionText.Equals("What's the time?"));

            // Answer options are correct
            string[] expectedOptions = new string[] { "12am", "12pm", "3pm" };
            CollectionAssert.AreEqual(mq.AnswerOptions, expectedOptions);

            // Answer is correct
            Assert.IsTrue(mq.Answer.Equals("3pm"));

        }

        [TestMethod]
        public void CheckCheckboxConstructor()
        {
            // Question text is correct
            Assert.IsTrue(ch.QuestionText.Equals("Which types of tests exist?"));

            // Answer options are correct
            string[] expectedOptions = new string[] { "func", "perf", "auro" };
            CollectionAssert.AreEqual(ch.AnswerOptions, expectedOptions);

            // Answer is correct
            string[] expectedAnswer = new string[] { "func", "perf" };
            CollectionAssert.AreEqual(ch.Answer, expectedAnswer);

        }
    }
}
