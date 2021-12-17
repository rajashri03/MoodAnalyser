using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Uc1-TC1.1--Should return Sad
        /// </summary>
        [TestMethod]
        public void GivingSadMessage_ShouldReturnSad()
        {
            Mood message = new Mood("I am in Sad Mood");
            string result = message.msg1;
            Assert.AreEqual("I am in Sad Mood", result);
        }
        /// <summary>
        /// Uc1-TC1.2-Should return Happy
        /// </summary>
        [TestMethod]
        public void GivingHappyMessage_ShouldReturnHappy()
        {
            Mood message = new Mood("I am in Happy Mood");
            string result = message.msg1;
            Assert.AreEqual("I am in Happy Mood", result);
        }
    }
}