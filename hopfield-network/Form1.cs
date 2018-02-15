using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Signals;

namespace HopfieldNetwork
{
    public partial class MainForm : Form
    {
        internal Bitmap originalBM;
        internal Bitmap transformedBM;

        string initDir;
        List<int[]> xs;
        int size;
        List<string> classes;

        protected HopfieldModel assotiatedMemory;
        
        int[] probe;
        int[] noised;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBoxesSplitContainer_SizeChanged(object sender, EventArgs e)
        {
            this.PictureBoxesSplitContainer.SplitterDistance = this.PictureBoxesSplitContainer.Size.Width / 2;
        }

        internal void visualizeBlackWhite(Bitmap bmp, int[] probe)
        {
            Debug.Assert(probe.Length == bmp.Width * bmp.Height);

            //using (var lb = new LockBitmap(bmp))
            var lb = bmp;
            {
                var i = 0;
                for (var y = 0; y < lb.Height; y++)
                {
                    for (var x = 0; x < lb.Width; x++)
                    {
                        var color = Color.Black;

                        if (probe[i] == 1)
                        {
                            color = Color.White;
                        }

                        lb.SetPixel(x, y, color);

                        ++i;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadImageButton_Click(sender, e);
        }

        private void originalPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                stateLabel.Text = "Working...";
                stateLabel.Refresh();

                initDir = folderBrowserDialog1.SelectedPath;

                InitHopfieldModel(initDir);

                stateLabel.Text = "Ready.";
                stateLabel.Refresh();
            }
        }

        private void InitHopfieldModel(string initDir)
        {
            var di = new DirectoryInfo(initDir);
            var files = di.GetFiles("*.jpg");

            size = files.Length;
            xs = new List<int[]>(size);
            classes = new List<string>(size);

            for (var i = 0; i < size; ++i)
            {
                var b = new Bitmap(Image.FromFile(files[i].FullName));
                var bipolarized = SignalProcessor.bipolarize(b, Color.FromArgb(0, 0, 0), 50);

                xs.Add(bipolarized);

                var className = Path.GetFileNameWithoutExtension(files[i].Name);
                classes.Add(className);
            }

            assotiatedMemory = new HopfieldModel(xs);
        }

        private void InitHopfieldModelFromTextData(string initDir)
        {
            var di = new DirectoryInfo(initDir);
            var files = di.GetFiles("*.txt");

            size = files.Length;
            xs = new List<int[]>(size);
            classes = new List<string>(size);

            for (var i = 0; i < size; ++i)
            {
                var numbers = new List<int>();

                var rows = File.ReadAllLines(files[i].FullName);
                foreach (var line in rows)
                {
                    var splitted = line.Split(' ');
                    foreach (var word in splitted)
                    {
                        if (word != "")
                        {
                            numbers.Add(int.Parse(word));
                        }
                    }
                }
                
                xs.Add(numbers.ToArray());

                var className = Path.GetFileNameWithoutExtension(files[i].Name);
                classes.Add(className);
            }

            assotiatedMemory = new HopfieldModel(xs);
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                openImageFileDialog.Title = "Open image...";
                openImageFileDialog.CheckFileExists = true;
                openImageFileDialog.CheckPathExists = true;

                openImageFileDialog.DefaultExt = "jpeg";
                openImageFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp|All Files|*.*";
                openImageFileDialog.FilterIndex = 1;
                openImageFileDialog.RestoreDirectory = true;

                if (openImageFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalBM = new Bitmap(openImageFileDialog.FileName);

                    probe = SignalProcessor.bipolarize(originalBM, Color.FromArgb(0, 0, 0));

                    transformedBM = originalBM.Clone() as Bitmap;
                    visualizeBlackWhite(transformedBM, probe);

                    originalPictureBox.Image = originalBM;
                    destinationPictureBox.Image = transformedBM;

                    stateLabel.Text = "Image loaded.";
                    stateLabel.Refresh();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("Failed loading image: {0}", ex.Message));
            }
        }

        private void addNoiseButton_Click(object sender, EventArgs e)
        {
            noised = SignalProcessor.addNoiseToBipolarizedArray(probe);

            visualizeBlackWhite(transformedBM, noised);
            destinationPictureBox.Refresh();
        }

        private void recallButton_Click(object sender, EventArgs e)
        {
            stateLabel.Text = "Working...";
            stateLabel.Refresh();

            var res = assotiatedMemory.recall(noised, this);

            var res_class = GetClassName(res);
            stateLabel.Text = string.Format("Result: {0}.", res_class);

            visualizeBlackWhite(transformedBM, res);
            destinationPictureBox.Refresh();
        }

        internal void refreshDestinationPictureBox()
        {
            destinationPictureBox.Refresh();
        }

        private string GetClassName(int[] y)
        {
            var index = getSampleIndex(y);
            return classes[index];
        }

        private int getSampleIndex(int[] y)
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

        private void storeFromTextDataButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
