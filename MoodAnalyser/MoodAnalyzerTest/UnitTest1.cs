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
            catch (MoodCustomException e)
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
        /// <summary>
        /// Reflection to Create MoodAnalyser with default Constructor - Create MoodAnalyserFactory and specify
        /// Tc4.1-Given MoodAnalyser  Class Name Should Return MoodAnalyser Object 
        /// </summary>
        [TestMethod]

        public void GivenMoodAnalyseClassName_ShouldreturnObject()
        {
            string message = null;
            object expected = new Mood(message);
            object obj = MoodAnlyserFactory.CreateMoodAnalyser("MoodAnalyser.Mood", "Mood");
            expected.Equals(obj);
        }
        /// <summary>
        /// Reflection to Create MoodAnalyser with default Constructor - Create MoodAnalyserFactory and specify
        /// Tc4.2-Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldreturnError()
        {
            string message = null;
            object expected = new Mood(message);
            object obj = MoodAnlyserFactory.CreateMoodAnalyser("MoodAnalyser.Wrongclass", "Wrongclass");
            expected.Equals(obj);
        }
        /// <summary>
        /// Reflection to Create MoodAnalyser with Parameter Constructor - Create MoodAnalyserFactory and specify
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldreturnObjectusingParameterisedConstructor()
        {
            object expected = new Mood("Happy");
            object obj = MoodAnlyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.Mood", "Mood", "Happy");
            expected.Equals(obj);
        }
    }
}