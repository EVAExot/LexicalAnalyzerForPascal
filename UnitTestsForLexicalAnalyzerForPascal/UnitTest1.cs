using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using LexicalAnalyzerForPascal;

namespace UnitTestsForLexicalAnalyzerForPascal
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тест проверки метода Analyze
        /// </summary>

        [TestMethod]
        public void AddCode_1_Returned_5_10_1_7()
        {
            string path = @"Code_1.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                (object, int, int, int, int) res = Form1.Analyze(sr.ReadToEnd());
                (int, int, int, int) new_res = (res.Item2, res.Item3, res.Item4, res.Item5);
                (int, int, int, int) expected = (5, 10, 1, 7);

                Assert.AreEqual(expected, new_res);
            }
        }

        [TestMethod]
        public void AddCode_2_Returned_5_9_2_5()
        {
            string path = @"Code_2.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                (object, int, int, int, int) res = Form1.Analyze(sr.ReadToEnd());
                (int, int, int, int) new_res = (res.Item2, res.Item3, res.Item4, res.Item5);
                (int, int, int, int) expected = (5, 9, 2, 5);

                Assert.AreEqual(expected, new_res);
            }
        }
    }
}
