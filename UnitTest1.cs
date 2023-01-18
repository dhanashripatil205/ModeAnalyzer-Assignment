using ModeAnalyzerAssignment;
//using MoodAnalyzer;
using System.Diagnostics.SymbolStore;
using System.Reflection;

namespace TestCaseMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void UseCase5_3()
        {
            try
            {

                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze_Parameter_Constructor("ModeAnalyzerAssignment.MoodAnalyser", "MoodAnar");
            }
            catch (MoodAnalyzerNullException Exception)
            {
                Assert.AreEqual("Constructor not found", Exception.Message);
            }
        }
     

    }
}
