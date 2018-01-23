namespace JpegRecompressor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuality = new System.Windows.Forms.TrackBar();
            this.chkChangeResolution = new System.Windows.Forms.CheckBox();
            this.gbChangeResolution = new System.Windows.Forms.GroupBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txbDestination = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.txbSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThread = new System.Windows.Forms.TrackBar();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).BeginInit();
            this.gbChangeResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThread)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(774, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 5);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(711, 199);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbThread);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbQuality);
            this.groupBox2.Controls.Add(this.chkChangeResolution);
            this.groupBox2.Controls.Add(this.gbChangeResolution);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDestination);
            this.groupBox2.Controls.Add(this.txbDestination);
            this.groupBox2.Controls.Add(this.btnSource);
            this.groupBox2.Controls.Add(this.txbSource);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quality Level";
            // 
            // tbQuality
            // 
            this.tbQuality.LargeChange = 2;
            this.tbQuality.Location = new System.Drawing.Point(212, 88);
            this.tbQuality.Minimum = 1;
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(274, 45);
            this.tbQuality.TabIndex = 8;
            this.tbQuality.Value = 3;
            // 
            // chkChangeResolution
            // 
            this.chkChangeResolution.AutoSize = true;
            this.chkChangeResolution.Location = new System.Drawing.Point(6, 65);
            this.chkChangeResolution.Name = "chkChangeResolution";
            this.chkChangeResolution.Size = new System.Drawing.Size(111, 17);
            this.chkChangeResolution.TabIndex = 7;
            this.chkChangeResolution.Text = "Change resolution";
            this.chkChangeResolution.UseVisualStyleBackColor = true;
            this.chkChangeResolution.CheckedChanged += new System.EventHandler(this.chkChangeResolution_CheckedChanged);
            // 
            // gbChangeResolution
            // 
            this.gbChangeResolution.Controls.Add(this.txbHeight);
            this.gbChangeResolution.Controls.Add(this.label4);
            this.gbChangeResolution.Controls.Add(this.label3);
            this.gbChangeResolution.Controls.Add(this.txbWidth);
            this.gbChangeResolution.Enabled = false;
            this.gbChangeResolution.Location = new System.Drawing.Point(6, 88);
            this.gbChangeResolution.Name = "gbChangeResolution";
            this.gbChangeResolution.Size = new System.Drawing.Size(200, 47);
            this.gbChangeResolution.TabIndex = 6;
            this.gbChangeResolution.TabStop = false;
            this.gbChangeResolution.Text = "Change resolution";
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(145, 19);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(43, 20);
            this.txbHeight.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(43, 19);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(43, 20);
            this.txbWidth.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source folder";
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(675, 34);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(35, 23);
            this.btnDestination.TabIndex = 3;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // txbDestination
            // 
            this.txbDestination.Location = new System.Drawing.Point(395, 36);
            this.txbDestination.Name = "txbDestination";
            this.txbDestination.Size = new System.Drawing.Size(274, 20);
            this.txbDestination.TabIndex = 2;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(286, 34);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(35, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txbSource
            // 
            this.txbSource.Location = new System.Drawing.Point(6, 36);
            this.txbSource.Name = "txbSource";
            this.txbSource.Size = new System.Drawing.Size(274, 20);
            this.txbSource.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thread count";
            // 
            // tbThread
            // 
            this.tbThread.LargeChange = 2;
            this.tbThread.Location = new System.Drawing.Point(494, 88);
            this.tbThread.Maximum = 50;
            this.tbThread.Minimum = 1;
            this.tbThread.Name = "tbThread";
            this.tbThread.Size = new System.Drawing.Size(274, 45);
            this.tbThread.TabIndex = 10;
            this.tbThread.Value = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).EndInit();
            this.gbChangeResolution.ResumeLayout(false);
            this.gbChangeResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txbDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txbSource;
        private System.Windows.Forms.CheckBox chkChangeResolution;
        private System.Windows.Forms.GroupBox gbChangeResolution;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbQuality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbThread;
    }
}

