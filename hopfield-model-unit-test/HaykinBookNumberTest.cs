using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HopfieldModelUnitTest
{
    [TestClass]
    public class HaykinBookNumberTest: HopfieldRecallTest
    {
        static string trainingSetDirectory = "..\\..\\..\\nn-signals-processing\\imageSets\\TrainingSetHaykinBookNumbers";

        [TestInitialize]
        public void Init()
        {
            base.Init(trainingSetDirectory);
        }

        [TestMethod]
        public void HaykinBookNumbersTest()
        {
            for (var i = 0; i < classes.Count; ++i)
            {
                Assert.AreEqual(i, recallIndex(i));
            }
        }
    }
}
