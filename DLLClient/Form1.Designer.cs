namespace DLLClient
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picDestination = new System.Windows.Forms.PictureBox();
            this.btnRemoveBG = new System.Windows.Forms.Button();
            this.chkfittodisplay = new System.Windows.Forms.CheckBox();
            this.pnlSource = new System.Windows.Forms.Panel();
            this.pnlDestination = new System.Windows.Forms.Panel();
            this.numbInsetRect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numIncrement = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chksample = new System.Windows.Forms.CheckBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).BeginInit();
            this.pnlSource.SuspendLayout();
            this.pnlDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbInsetRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncrement)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(1415, 95);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(39, 13);
            this.lblstatus.TabIndex = 3;
            this.lblstatus.Text = "Output";
            // 
            // picSource
            // 
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Location = new System.Drawing.Point(3, 3);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(816, 719);
            this.picSource.TabIndex = 4;
            this.picSource.TabStop = false;
            // 
            // picDestination
            // 
            this.picDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDestination.Location = new System.Drawing.Point(3, 3);
            this.picDestination.Name = "picDestination";
            this.picDestination.Size = new System.Drawing.Size(846, 716);
            this.picDestination.TabIndex = 4;
            this.picDestination.TabStop = false;
            // 
            // btnRemoveBG
            // 
            this.btnRemoveBG.Location = new System.Drawing.Point(837, 126);
            this.btnRemoveBG.Name = "btnRemoveBG";
            this.btnRemoveBG.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveBG.TabIndex = 0;
            this.btnRemoveBG.Text = "Remove BG >>";
            this.btnRemoveBG.UseVisualStyleBackColor = true;
            this.btnRemoveBG.Click += new System.EventHandler(this.btnRemoveBG_Click);
            // 
            // chkfittodisplay
            // 
            this.chkfittodisplay.AutoSize = true;
            this.chkfittodisplay.Location = new System.Drawing.Point(93, 31);
            this.chkfittodisplay.Name = "chkfittodisplay";
            this.chkfittodisplay.Size = new System.Drawing.Size(129, 17);
            this.chkfittodisplay.TabIndex = 5;
            this.chkfittodisplay.Text = "Zoom to fit to display?";
            this.chkfittodisplay.UseVisualStyleBackColor = true;
            this.chkfittodisplay.CheckedChanged += new System.EventHandler(this.chkfittodisplay_CheckedChanged);
            // 
            // pnlSource
            // 
            this.pnlSource.Controls.Add(this.picSource);
            this.pnlSource.Location = new System.Drawing.Point(12, 120);
            this.pnlSource.Name = "pnlSource";
            this.pnlSource.Size = new System.Drawing.Size(822, 725);
            this.pnlSource.TabIndex = 6;
            // 
            // pnlDestination
            // 
            this.pnlDestination.Controls.Add(this.picDestination);
            this.pnlDestination.Location = new System.Drawing.Point(941, 123);
            this.pnlDestination.Name = "pnlDestination";
            this.pnlDestination.Size = new System.Drawing.Size(852, 722);
            this.pnlDestination.TabIndex = 7;
            // 
            // numbInsetRect
            // 
            this.numbInsetRect.Location = new System.Drawing.Point(518, 25);
            this.numbInsetRect.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numbInsetRect.Name = "numbInsetRect";
            this.numbInsetRect.Size = new System.Drawing.Size(120, 20);
            this.numbInsetRect.TabIndex = 8;
            this.numbInsetRect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Percentage % Inset Rect (Greater value smaller rect)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numIncrement
            // 
            this.numIncrement.Location = new System.Drawing.Point(518, 51);
            this.numIncrement.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numIncrement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIncrement.Name = "numIncrement";
            this.numIncrement.Size = new System.Drawing.Size(120, 20);
            this.numIncrement.TabIndex = 8;
            this.numIncrement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Iterations (1-3)";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // chksample
            // 
            this.chksample.AutoSize = true;
            this.chksample.Checked = true;
            this.chksample.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksample.Location = new System.Drawing.Point(339, 51);
            this.chksample.Name = "chksample";
            this.chksample.Size = new System.Drawing.Size(93, 17);
            this.chksample.TabIndex = 5;
            this.chksample.Text = "Sample Image";
            this.chksample.UseVisualStyleBackColor = true;
            this.chksample.CheckedChanged += new System.EventHandler(this.chkfittodisplay_CheckedChanged);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(795, 95);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(36, 13);
            this.lbltimer.TabIndex = 10;
            this.lbltimer.Text = "Time: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 857);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numIncrement);
            this.Controls.Add(this.numbInsetRect);
            this.Controls.Add(this.pnlDestination);
            this.Controls.Add(this.pnlSource);
            this.Controls.Add(this.chksample);
            this.Controls.Add(this.chkfittodisplay);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveBG);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Logo Detector";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).EndInit();
            this.pnlSource.ResumeLayout(false);
            this.pnlDestination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numbInsetRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncrement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.PictureBox picDestination;
        private System.Windows.Forms.Button btnRemoveBG;
        private System.Windows.Forms.CheckBox chkfittodisplay;
        private System.Windows.Forms.Panel pnlSource;
        private System.Windows.Forms.Panel pnlDestination;
        private System.Windows.Forms.NumericUpDown numbInsetRect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numIncrement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chksample;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer1;
    }
}

