using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using HopfieldNetwork;
using System.Linq;
using Signals;

namespace HopfieldModelUnitTest
{
    [TestClass]
    public abstract class HopfieldRecallTest
    {
        protected Random rand;
        protected List<int[]> xs;
        protected int size;
        protected List<string> classes;

        protected HopfieldModel assotiatedMemory;

        public void Init(string trainingSetDirectory)
        {
            rand = new Random();

            var di = new DirectoryInfo(trainingSetDirectory);
            var files = di.GetFiles("*.jpg");

            size = files.Length;
            xs = new List<int[]>(size);
            classes = new List<string>(size);

            for (var i = 0; i < size; ++i)
            {
                var b = new Bitmap(Image.FromFile(files[i].FullName));

                var bip_res = SignalProcessor.bipolarize(b, Color.FromArgb(0, 0, 0));
                xs.Add(bip_res.Cast<int>().ToArray());

                classes.Add(files[i].Name);
            }

            assotiatedMemory = new HopfieldModel(xs);
        }

        public int recallIndex(int sampleIndex)
        {
            var probe = xs[sampleIndex];

            SignalProcessor.addNoiseToBipolarizedArray(probe);

            var y = assotiatedMemory.recall(probe);

            var ind = getSampleIndex(y);

            return ind;
        }

        public int getSampleIndex(int[] y)
        {
            var ind = 0;
            var minHammingDist = HopfieldModel.hammingDistance(xs[0], y);

            for (var i = 1; i < xs.Count; ++i)
            {
                var hd = HopfieldModel.hammingDistance(xs[i], y);
                if (hd < minHammingDist)
                {
                    ind = i;
                    minHammingDist = hd;
                }
            }

            return ind;
        }
    }
}
