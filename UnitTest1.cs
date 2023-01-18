using ModeAnalyzerAssignment;
//using MoodAnalyzer;
using System.Diagnostics.SymbolStore;

namespace TestCaseMoodAnalyzer
{
   
 [TestClass]
    public class UnitTest1
    {
     [TestMethod]
        public void UseCase4_3()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("ModeAnalyzerAssignment.MoodAnalyzer", "MoodAnalyz");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Constructor not found", Exception.Message);
            }
        }
    }
}
