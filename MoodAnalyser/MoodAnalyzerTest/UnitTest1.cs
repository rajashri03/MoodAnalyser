using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Mood Should not be Empty
        /// </summary>
        /// <param name="msg"></param>
        [TestMethod]
        public void GivingEmptyMood_ShouldReturnException_EmptyMood()
        {
            try
            {
                //Arrange
                string message = "";
                Mood moodanlysis = new Mood(message);
                //Act
                string actual = moodanlysis.analysisMood();
            }
            catch(MoodCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        /// <summary>
        /// Mood should not null
        /// </summary>
        /// <param name="msg"></param>
        [TestMethod]
        public void GivingNullMood_ShouldReturnException_NullMood()
        {
            try
            {
                //Arrange
                string message = null;
                Mood moodanlysis = new Mood(message);
                //Act
                string actual = moodanlysis.analysisMood();
            }
            catch (MoodCustomException e)
            {
                //Asset
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
    }
}