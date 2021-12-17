using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {

        string msg1;
        /// <summary>
        /// Mood Analyser-Checking Happy and sad Mood Status
        /// Parameterized Constructor
        /// </summary>
        /// <param name="msg"></param>
        public Mood(string msg)
        {
            msg1 = msg;
        }
        /// <summary>
        /// Method to return Mood Status
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public string analysisMood()
        {
            try
            {
                if (msg1.Equals(string.Empty))
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.Empty_Message, "Mood should not be empty");
                }
                if (msg1.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodCustomException(MoodCustomException.ExpType.Null_Message, "Mood should not be Null");
            }

        }
    }
}
