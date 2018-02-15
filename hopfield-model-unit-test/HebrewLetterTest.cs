using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HopfieldModelUnitTest
{
    [TestClass]
    public class HebrewLetterTest: HopfieldRecallTest
    {
        static string trainingSetDirectory = "..\\..\\..\\nn-signals-processing\\imageSets\\TrainingSetHebrewLetters";

        [TestInitialize]
        public void Init()
        {
            base.Init(trainingSetDirectory);
        }

        [TestMethod]
        public void HebrewLettersTest()
        {
            for (var i = 0; i < classes.Count; ++i)
            {
                Assert.AreEqual(i, recallIndex(i));
            }
        }
    }
}
