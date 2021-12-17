using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Uc2-null message should return Happy
        /// </summary>
        /// <param name="msg"></param>
        [TestMethod]
        [DataRow(null)]
        public void GivingHappyMessage_ShouldReturnHappy(string msg)
        {
            Mood message = new Mood("Happy");
            string actual = message.analysisMood();
            string expected = "Happy";
            Assert.AreEqual(expected, actual);
        }
    }
}