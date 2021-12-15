using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    /// <summary>
    /// Mood Analyser-Checking Happy and sad Mood Status
    /// </summary>
    public class Mood
    {
        string msg1 = "I am in Sad Mood";
        /// <summary>
        /// Method to return Mood Status
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public string analysisMood(string msg)
        {
            if (msg1.ToUpper().Contains(msg.ToUpper()))
            {
                return msg1;
            }
            else
            {
                return "I am in Happy Mood";
            }
        }
    }
}
