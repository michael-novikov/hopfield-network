using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HopfieldModelUnitTest
{
    [TestClass]
    public class ArabicNumberTest: HopfieldRecallTest
    {
        static string trainingSetDirectory = "..\\..\\..\\nn-signals-processing\\imageSets\\TrainingSetArabicNumbers";

        [TestInitialize]
        public void Init()
        {
            base.Init(trainingSetDirectory);
        }

        [TestMethod]
        public void ArabicNumbersTest()
        {
            for (var i = 0; i < classes.Count; ++i)
            {
                Assert.AreEqual(i, recallIndex(i));
            }
        }
    }
}
