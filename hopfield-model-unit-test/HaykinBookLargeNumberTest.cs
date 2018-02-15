using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HopfieldModelUnitTest
{
    [TestClass]
    public class HaykinBookLargeNumberTest: HopfieldRecallTest
    {
        static string trainingSetDirectory = "..\\..\\..\\nn-signals-processing\\imageSets\\TrainingSetHaykinBookLargeNumbers";

        [TestInitialize]
        public void Init()
        {
            base.Init(trainingSetDirectory);
        }

        [TestMethod]
        public void HaykinBookLargeNumbersTest()
        {
            for (var i = 0; i < classes.Count; ++i)
            {
                Assert.AreEqual(i, recallIndex(i));
            }
        }
    }
}
