namespace HopfieldNetwork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PictureBoxesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.destinationPictureBox = new System.Windows.Forms.PictureBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.addNoiseButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.storeButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxesSplitContainer)).BeginInit();
            this.PictureBoxesSplitContainer.Panel1.SuspendLayout();
            this.PictureBoxesSplitContainer.Panel2.SuspendLayout();
            this.PictureBoxesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.PictureBoxesSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.stateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.button4);
            this.mainSplitContainer.Panel2.Controls.Add(this.addNoiseButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.loadImageButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.storeButton);
            this.mainSplitContainer.Panel2MinSize = 50;
            this.mainSplitContainer.Size = new System.Drawing.Size(1008, 657);
            this.mainSplitContainer.SplitterDistance = 601;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // PictureBoxesSplitContainer
            // 
            this.PictureBoxesSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxesSplitContainer.IsSplitterFixed = true;
            this.PictureBoxesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxesSplitContainer.Name = "PictureBoxesSplitContainer";
            // 
            // PictureBoxesSplitContainer.Panel1
            // 
            this.PictureBoxesSplitContainer.Panel1.AutoScroll = true;
            this.PictureBoxesSplitContainer.Panel1.Controls.Add(this.originalPictureBox);
            // 
            // PictureBoxesSplitContainer.Panel2
            // 
            this.PictureBoxesSplitContainer.Panel2.AutoScroll = true;
            this.PictureBoxesSplitContainer.Panel2.Controls.Add(this.destinationPictureBox);
            this.PictureBoxesSplitContainer.Size = new System.Drawing.Size(1008, 601);
            this.PictureBoxesSplitContainer.SplitterDistance = 504;
            this.PictureBoxesSplitContainer.TabIndex = 0;
            this.PictureBoxesSplitContainer.SizeChanged += new System.EventHandler(this.PictureBoxesSplitContainer_SizeChanged);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(502, 599);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.originalPictureBox_MouseClick);
            // 
            // destinationPictureBox
            // 
            this.destinationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationPictureBox.Location = new System.Drawing.Point(0, 0);
            this.destinationPictureBox.Name = "destinationPictureBox";
            this.destinationPictureBox.Size = new System.Drawing.Size(498, 599);
            this.destinationPictureBox.TabIndex = 0;
            this.destinationPictureBox.TabStop = false;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.Location = new System.Drawing.Point(506, 16);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(21, 20);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "   ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(380, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Recall";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.recallButton_Click);
            // 
            // addNoiseButton
            // 
            this.addNoiseButton.Location = new System.Drawing.Point(254, 3);
            this.addNoiseButton.Name = "addNoiseButton";
            this.addNoiseButton.Size = new System.Drawing.Size(120, 40);
            this.addNoiseButton.TabIndex = 2;
            this.addNoiseButton.Text = "Add Noise";
            this.addNoiseButton.UseVisualStyleBackColor = true;
            this.addNoiseButton.Click += new System.EventHandler(this.addNoiseButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(129, 3);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(120, 40);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(3, 3);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(120, 40);
            this.storeButton.TabIndex = 0;
            this.storeButton.Text = "Store From Images";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openImageToolStripMenuItem.Text = "Open  image...";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.FileName = "image.jpg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopfield Model";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.PictureBoxesSplitContainer.Panel1.ResumeLayout(false);
            this.PictureBoxesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxesSplitContainer)).EndInit();
            this.PictureBoxesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPictureBox)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer PictureBoxesSplitContainer;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox destinationPictureBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button addNoiseButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label stateLabel;
    }
}

