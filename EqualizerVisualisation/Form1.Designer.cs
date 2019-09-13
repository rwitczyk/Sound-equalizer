using System.Windows.Forms;

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
            this.timerVisualization = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.verticalProgressBar11 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar10 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar9 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar8 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar7 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar6 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar5 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar4 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar3 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar2 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar1 = new EqualizerVisualisation.verticalProgressBar();
            this.verticalProgressBar12 = new EqualizerVisualisation.verticalProgressBar();
            this.SuspendLayout();
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(119, 698);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarTime.MarqueeAnimationSpeed = 1000;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(805, 27);
            this.progressBarTime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 153);
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
            this.button2.Location = new System.Drawing.Point(870, 153);
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
            this.textBox1.Location = new System.Drawing.Point(119, 667);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(757, 235);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Zatrzymaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // timerVisualization
            // 
            this.timerVisualization.Enabled = true;
            this.timerVisualization.Tick += new System.EventHandler(this.TimerVisualization_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(757, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 32);
            this.button4.TabIndex = 27;
            this.button4.Text = "Wybierz plik";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // verticalProgressBar11
            // 
            this.verticalProgressBar11.Location = new System.Drawing.Point(624, 74);
            this.verticalProgressBar11.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar11.Name = "verticalProgressBar11";
            this.verticalProgressBar11.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar11.TabIndex = 26;
            // 
            // verticalProgressBar10
            // 
            this.verticalProgressBar10.Location = new System.Drawing.Point(574, 74);
            this.verticalProgressBar10.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar10.Name = "verticalProgressBar10";
            this.verticalProgressBar10.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar10.TabIndex = 25;
            // 
            // verticalProgressBar9
            // 
            this.verticalProgressBar9.Location = new System.Drawing.Point(524, 74);
            this.verticalProgressBar9.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar9.Name = "verticalProgressBar9";
            this.verticalProgressBar9.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar9.TabIndex = 24;
            // 
            // verticalProgressBar8
            // 
            this.verticalProgressBar8.Location = new System.Drawing.Point(474, 74);
            this.verticalProgressBar8.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar8.Name = "verticalProgressBar8";
            this.verticalProgressBar8.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar8.TabIndex = 23;
            // 
            // verticalProgressBar7
            // 
            this.verticalProgressBar7.Location = new System.Drawing.Point(423, 74);
            this.verticalProgressBar7.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar7.Name = "verticalProgressBar7";
            this.verticalProgressBar7.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar7.TabIndex = 22;
            // 
            // verticalProgressBar6
            // 
            this.verticalProgressBar6.Location = new System.Drawing.Point(372, 74);
            this.verticalProgressBar6.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar6.Name = "verticalProgressBar6";
            this.verticalProgressBar6.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar6.TabIndex = 21;
            // 
            // verticalProgressBar5
            // 
            this.verticalProgressBar5.Location = new System.Drawing.Point(322, 74);
            this.verticalProgressBar5.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar5.Name = "verticalProgressBar5";
            this.verticalProgressBar5.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar5.TabIndex = 20;
            // 
            // verticalProgressBar4
            // 
            this.verticalProgressBar4.Location = new System.Drawing.Point(271, 74);
            this.verticalProgressBar4.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar4.Name = "verticalProgressBar4";
            this.verticalProgressBar4.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar4.TabIndex = 19;
            // 
            // verticalProgressBar3
            // 
            this.verticalProgressBar3.Location = new System.Drawing.Point(220, 74);
            this.verticalProgressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar3.Name = "verticalProgressBar3";
            this.verticalProgressBar3.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar3.TabIndex = 18;
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.Location = new System.Drawing.Point(170, 74);
            this.verticalProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar2.TabIndex = 17;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(119, 74);
            this.verticalProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar1.TabIndex = 16;
            // 
            // verticalProgressBar12
            // 
            this.verticalProgressBar12.Location = new System.Drawing.Point(675, 74);
            this.verticalProgressBar12.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar12.Name = "verticalProgressBar12";
            this.verticalProgressBar12.Size = new System.Drawing.Size(43, 531);
            this.verticalProgressBar12.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 763);
            this.Controls.Add(this.verticalProgressBar12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.verticalProgressBar11);
            this.Controls.Add(this.verticalProgressBar10);
            this.Controls.Add(this.verticalProgressBar9);
            this.Controls.Add(this.verticalProgressBar8);
            this.Controls.Add(this.verticalProgressBar7);
            this.Controls.Add(this.verticalProgressBar6);
            this.Controls.Add(this.verticalProgressBar5);
            this.Controls.Add(this.verticalProgressBar4);
            this.Controls.Add(this.verticalProgressBar3);
            this.Controls.Add(this.verticalProgressBar2);
            this.Controls.Add(this.verticalProgressBar1);
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
        private System.Windows.Forms.Timer timerVisualization;
        private verticalProgressBar verticalProgressBar1;
        private verticalProgressBar verticalProgressBar2;
        private verticalProgressBar verticalProgressBar3;
        private verticalProgressBar verticalProgressBar4;
        private verticalProgressBar verticalProgressBar5;
        private verticalProgressBar verticalProgressBar6;
        private verticalProgressBar verticalProgressBar7;
        private verticalProgressBar verticalProgressBar8;
        private verticalProgressBar verticalProgressBar9;
        private verticalProgressBar verticalProgressBar10;
        private verticalProgressBar verticalProgressBar11;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private verticalProgressBar verticalProgressBar12;
    }
}

