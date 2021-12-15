using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        string msg1 = "I am in Sad Mood";
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
