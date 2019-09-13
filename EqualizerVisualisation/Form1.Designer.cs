namespace EqualizerVisualisation
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
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timerVisualization = new System.Windows.Forms.Timer(this.components);
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(128, 442);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarTime.MarqueeAnimationSpeed = 1000;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(805, 27);
            this.progressBarTime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Uruchom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(873, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pauza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 403);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(757, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Zatrzymaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(128, 54);
            this.progressBar1.Maximum = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(520, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(128, 83);
            this.progressBar2.Maximum = 300;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(520, 20);
            this.progressBar2.TabIndex = 7;
            // 
            // timerVisualization
            // 
            this.timerVisualization.Enabled = true;
            this.timerVisualization.Tick += new System.EventHandler(this.TimerVisualization_Tick);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(128, 109);
            this.progressBar3.Maximum = 300;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(520, 20);
            this.progressBar3.TabIndex = 8;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(128, 135);
            this.progressBar4.Maximum = 300;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(520, 20);
            this.progressBar4.TabIndex = 9;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(128, 161);
            this.progressBar5.Maximum = 300;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(520, 20);
            this.progressBar5.TabIndex = 10;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(128, 187);
            this.progressBar6.Maximum = 300;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(520, 20);
            this.progressBar6.TabIndex = 11;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(128, 213);
            this.progressBar7.Maximum = 300;
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(520, 20);
            this.progressBar7.TabIndex = 12;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(128, 239);
            this.progressBar8.Maximum = 300;
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(520, 20);
            this.progressBar8.TabIndex = 13;
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(128, 265);
            this.progressBar9.Maximum = 300;
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(520, 20);
            this.progressBar9.TabIndex = 14;
            // 
            // progressBar10
            // 
            this.progressBar10.Location = new System.Drawing.Point(128, 291);
            this.progressBar10.Maximum = 300;
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(520, 20);
            this.progressBar10.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.progressBar10);
            this.Controls.Add(this.progressBar9);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timerVisualization;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar10;
    }
}

