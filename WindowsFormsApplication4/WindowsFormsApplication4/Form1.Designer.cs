namespace WindowsFormsApplication4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.namelb = new System.Windows.Forms.Label();
            this.quiz = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.RadioButton();
            this.ch2 = new System.Windows.Forms.RadioButton();
            this.ch3 = new System.Windows.Forms.RadioButton();
            this.ch4 = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(2, 15);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(120, 26);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "Enter Name";
            this.namelb.Click += new System.EventHandler(this.label1_Click);
            // 
            // quiz
            // 
            this.quiz.AutoSize = true;
            this.quiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz.Location = new System.Drawing.Point(194, 210);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(497, 108);
            this.quiz.TabIndex = 2;
            this.quiz.Text = "Fun Quiz!!";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(65, 47);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(87, 177);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(357, 33);
            this.question.TabIndex = 4;
            this.question.Text = "Test Test test test test test";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.question.Visible = false;
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch1.Location = new System.Drawing.Point(133, 321);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(65, 29);
            this.ch1.TabIndex = 5;
            this.ch1.TabStop = true;
            this.ch1.Text = "ch1";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.Visible = false;
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch2.Location = new System.Drawing.Point(525, 321);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(65, 29);
            this.ch2.TabIndex = 6;
            this.ch2.TabStop = true;
            this.ch2.Text = "ch2";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.Visible = false;
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch3.Location = new System.Drawing.Point(133, 413);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(65, 29);
            this.ch3.TabIndex = 7;
            this.ch3.TabStop = true;
            this.ch3.Text = "ch3";
            this.ch3.UseVisualStyleBackColor = true;
            this.ch3.Visible = false;
            // 
            // ch4
            // 
            this.ch4.AutoSize = true;
            this.ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch4.Location = new System.Drawing.Point(525, 413);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(65, 29);
            this.ch4.TabIndex = 8;
            this.ch4.TabStop = true;
            this.ch4.Text = "ch4";
            this.ch4.UseVisualStyleBackColor = true;
            this.ch4.Visible = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(321, 491);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(96, 28);
            this.next.TabIndex = 9;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score :";
            this.label1.Visible = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(88, 47);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(24, 25);
            this.score.TabIndex = 11;
            this.score.Text = "0";
            this.score.Visible = false;
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.Location = new System.Drawing.Point(843, 21);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(23, 28);
            this.sec.TabIndex = 12;
            this.sec.Text = "0";
            this.sec.Visible = false;
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(820, 21);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(17, 28);
            this.i.TabIndex = 13;
            this.i.Text = ":";
            this.i.Visible = false;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(791, 21);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(23, 28);
            this.min.TabIndex = 14;
            this.min.Text = "2";
            this.min.Visible = false;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(714, 21);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(71, 28);
            this.t.TabIndex = 15;
            this.t.Text = "Timer";
            this.t.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(876, 563);
            this.Controls.Add(this.t);
            this.Controls.Add(this.min);
            this.Controls.Add(this.i);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.start);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label quiz;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton ch1;
        private System.Windows.Forms.RadioButton ch2;
        private System.Windows.Forms.RadioButton ch3;
        private System.Windows.Forms.RadioButton ch4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Timer timer1;
    }
}

