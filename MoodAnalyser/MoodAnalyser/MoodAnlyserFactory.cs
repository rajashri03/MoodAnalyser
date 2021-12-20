using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnlyserFactory
    {
        /// <summary>
        /// CreateMoodAnalyser Method to create object of MoodAnalyser class 
        ///</summary>
        /// <param name="ClassName"></param>
        /// <param name="ConstructorName"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyser(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
    }
}
