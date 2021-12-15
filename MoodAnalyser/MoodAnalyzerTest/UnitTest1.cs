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
            Mood message = new Mood();
            string result = message.analysisMood("I am in Sad Mood");
            Assert.AreEqual("I am in Sad Mood", result);
        }
        [TestMethod]
        public void GivingSadMessage_ShouldReturnHappy()
        {
            Mood message = new Mood();
            string result = message.analysisMood("I am in Happy Mood");
            Assert.AreEqual("I am in Happy Mood", result);
        }
    }
}