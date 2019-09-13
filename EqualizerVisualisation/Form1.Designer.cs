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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerVisualization = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.verticalProgressBar12 = new EqualizerVisualisation.verticalProgressBar();
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
            this.SuspendLayout();
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(361, 556);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarTime.MarqueeAnimationSpeed = 1000;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(571, 22);
            this.progressBarTime.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(858, 520);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerVisualization
            // 
            this.timerVisualization.Enabled = true;
            this.timerVisualization.Tick += new System.EventHandler(this.TimerVisualization_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Image = global::EqualizerVisualisation.Properties.Resources.beka;
            this.button4.Location = new System.Drawing.Point(27, 527);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 51);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::EqualizerVisualisation.Properties.Resources.htgg1;
            this.button2.Location = new System.Drawing.Point(144, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 65);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::EqualizerVisualisation.Properties.Resources.hehe1;
            this.button1.Location = new System.Drawing.Point(63, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 65);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(483, 527);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 29;
            // 
            // verticalProgressBar12
            // 
            this.verticalProgressBar12.Location = new System.Drawing.Point(900, 73);
            this.verticalProgressBar12.Maximum = 20000;
            this.verticalProgressBar12.Name = "verticalProgressBar12";
            this.verticalProgressBar12.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar12.TabIndex = 28;
            // 
            // verticalProgressBar11
            // 
            this.verticalProgressBar11.Location = new System.Drawing.Point(862, 73);
            this.verticalProgressBar11.Maximum = 20000;
            this.verticalProgressBar11.Name = "verticalProgressBar11";
            this.verticalProgressBar11.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar11.TabIndex = 26;
            // 
            // verticalProgressBar10
            // 
            this.verticalProgressBar10.Location = new System.Drawing.Point(824, 73);
            this.verticalProgressBar10.Maximum = 20000;
            this.verticalProgressBar10.Name = "verticalProgressBar10";
            this.verticalProgressBar10.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar10.TabIndex = 25;
            // 
            // verticalProgressBar9
            // 
            this.verticalProgressBar9.Location = new System.Drawing.Point(787, 73);
            this.verticalProgressBar9.Maximum = 20000;
            this.verticalProgressBar9.Name = "verticalProgressBar9";
            this.verticalProgressBar9.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar9.TabIndex = 24;
            // 
            // verticalProgressBar8
            // 
            this.verticalProgressBar8.Location = new System.Drawing.Point(750, 73);
            this.verticalProgressBar8.Maximum = 20000;
            this.verticalProgressBar8.Name = "verticalProgressBar8";
            this.verticalProgressBar8.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar8.TabIndex = 23;
            // 
            // verticalProgressBar7
            // 
            this.verticalProgressBar7.Location = new System.Drawing.Point(711, 73);
            this.verticalProgressBar7.Maximum = 20000;
            this.verticalProgressBar7.Name = "verticalProgressBar7";
            this.verticalProgressBar7.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar7.TabIndex = 22;
            // 
            // verticalProgressBar6
            // 
            this.verticalProgressBar6.Location = new System.Drawing.Point(673, 73);
            this.verticalProgressBar6.Maximum = 20000;
            this.verticalProgressBar6.Name = "verticalProgressBar6";
            this.verticalProgressBar6.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar6.TabIndex = 21;
            // 
            // verticalProgressBar5
            // 
            this.verticalProgressBar5.Location = new System.Drawing.Point(636, 73);
            this.verticalProgressBar5.Maximum = 20000;
            this.verticalProgressBar5.Name = "verticalProgressBar5";
            this.verticalProgressBar5.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar5.TabIndex = 20;
            // 
            // verticalProgressBar4
            // 
            this.verticalProgressBar4.Location = new System.Drawing.Point(597, 73);
            this.verticalProgressBar4.Maximum = 20000;
            this.verticalProgressBar4.Name = "verticalProgressBar4";
            this.verticalProgressBar4.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar4.TabIndex = 19;
            // 
            // verticalProgressBar3
            // 
            this.verticalProgressBar3.Location = new System.Drawing.Point(559, 73);
            this.verticalProgressBar3.Maximum = 20000;
            this.verticalProgressBar3.Name = "verticalProgressBar3";
            this.verticalProgressBar3.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar3.TabIndex = 18;
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.Location = new System.Drawing.Point(522, 73);
            this.verticalProgressBar2.Maximum = 20000;
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar2.TabIndex = 17;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(483, 73);
            this.verticalProgressBar1.Maximum = 20000;
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(32, 431);
            this.verticalProgressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EqualizerVisualisation.Properties.Resources.kkk;
            this.ClientSize = new System.Drawing.Size(957, 620);
            this.Controls.Add(this.textBox2);
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarTime);
            this.Name = "Form1";
            this.Text = "SOUND EQUALIZER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
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
        private TextBox textBox2;
    }
}

