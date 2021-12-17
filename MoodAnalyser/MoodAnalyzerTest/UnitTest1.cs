using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivingSadMessage_ShouldReturnSad()
        {
            Mood message = new Mood("I am in Sad Mood");
            string result = message.msg1;
            Assert.AreEqual("I am in Sad Mood", result);
        }
        [TestMethod]
        public void GivingHappyMessage_ShouldReturnHappy()
        {
            Mood message = new Mood("I am in Happy Mood");
            string result = message.msg1;
            Assert.AreEqual("I am in Happy Mood", result);
        }
    }
}