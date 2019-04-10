using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int D=0;//for question
        int C = 0;//for choices 
        int A = 0;//for Ans
        int m = 1;
        int s = 60;
        int Score = 0;
        ArrayList qu = new ArrayList();
        ArrayList choice = new ArrayList();
        ArrayList ans = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            qu.Add("How long is the Great Wall of China?");
            qu.Add("What is called a meal in open air?");
            qu.Add("What kind of animal is the largest living creature on Earth?");
            qu.Add("Which unit is an indication for the sound quality of MP3?");
            qu.Add("In computing what is Ram short for?");

            choice.Add("1000 miles");
            choice.Add("4000 miles");//
            choice.Add("5000 miles");
            choice.Add("7000 miles");

            choice.Add("Lunch");
            choice.Add("Party");
            choice.Add("Picnic");//
            choice.Add("Dinner");

            choice.Add("Horse");
            choice.Add("Cow");
            choice.Add("Elephant");
            choice.Add("Whale");//

            choice.Add("Kbps");//
            choice.Add("Mbps");
            choice.Add("Gbps");
            choice.Add("Tbps");

            choice.Add("Read Allow Memory");
            choice.Add("Random Allow Memory");
            choice.Add("Red Access Memory");
            choice.Add("Random Access Memory");

            ans.Add("4000 miles");
            ans.Add("Picnic");
            ans.Add("Whale");
            ans.Add("Kbps");
            ans.Add("Random Access Memory");

            if (textBox1.Text != String.Empty)
            {
                score.Text = Score.ToString();
                question.Text = qu[D].ToString();
                ch1.Text = choice[C].ToString();
                C++;
                ch2.Text = choice[C].ToString();
                C++;
                ch3.Text = choice[C].ToString();
                C++;
                ch4.Text = choice[C].ToString();

                namelb.Text = textBox1.Text;
                textBox1.Visible = false;
                start.Visible = false;
                next.Enabled = true;

                quiz.Visible = false;
                question.Visible = true;
                ch1.Visible = true;
                ch2.Visible = true;
                ch3.Visible = true;
                ch4.Visible = true;
                next.Visible = true;

                t.Visible = true;
                i.Visible = true;
                min.Visible = true;
                sec.Visible = true;

                score.Visible = true;
                label1.Visible = true;

                min.Text = m.ToString();
                sec.Text = s.ToString();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
           if(m==0 && (int.Parse(sec.Text) == 0))
            {
                timer1.Stop();
                MessageBox.Show("Time Up \n Try Again Next time");
                D = 0;
                C = 0;
                A = 0;
                Score = 0;
                namelb.Text = "Enter Name";
                textBox1.Visible = true;
                start.Visible = true;
                next.Enabled = false;

                quiz.Visible = true;
                question.Visible = false;
                ch1.Visible = false;
                ch2.Visible = false;
                ch3.Visible = false;
                ch4.Visible = false;
                next.Visible = false;

                t.Visible = false;
                i.Visible = false;
                min.Visible = false;
                sec.Visible = false;

                score.Visible = false;
                label1.Visible = false;

                m =2;
            }
            if (m != 0 && int.Parse(sec.Text) == 0) {
                m--;
                min.Text = m.ToString();
                sec.Text = s.ToString();
            }
            if(int.Parse(sec.Text)!=0)
            sec.Text = (int.Parse(sec.Text) - 1).ToString();

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (ch1.Checked == true && ch1.Text.Equals(ans[A].ToString()))
            {
                MessageBox.Show("Correct Answer");
               A++; 
                Score++;
                score.Text = Score.ToString();
                ch1.Checked = false;
            }
            else if (ch2.Checked == true && ch2.Text.Equals(ans[A].ToString()))
            {
                MessageBox.Show("Correct Answer");
                A++;
                Score++;
                score.Text = Score.ToString();
                ch2.Checked = false;
            }
            else if (ch3.Checked == true && ch3.Text.Equals(ans[A].ToString()))
            {
                MessageBox.Show("Correct Answer");
                A++;
                Score++;
                score.Text = Score.ToString();
                ch3.Checked = false;
            }
            else if (ch4.Checked == true && ch4.Text.Equals(ans[A].ToString()))
            {
                MessageBox.Show("Correct Answer");
                A++;
                Score++;
                score.Text = Score.ToString();
                ch4.Checked = false;
                
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                A++;
                ch1.Checked = false;
                ch2.Checked = false;
                ch3.Checked = false;
                ch4.Checked = false;
            }
            if (D <= 3 && C <= 18)
            {
                D++;
                question.Text = qu[D].ToString();
                C++;
                ch1.Text = choice[C].ToString();
                C++;
                ch2.Text = choice[C].ToString();
                C++;
                ch3.Text = choice[C].ToString();
                C++;
                ch4.Text = choice[C].ToString();
            }
            else
            {
                timer1.Stop();
                namelb.Text = "Enter Name";
                textBox1.Visible = true;
                start.Visible = true;
                next.Enabled = false;

                quiz.Visible = true;
                question.Visible = false;
                ch1.Visible = false;
                ch2.Visible = false;
                ch3.Visible = false;
                ch4.Visible = false;
                next.Visible = false;

                t.Visible = false;
                i.Visible = false;
                min.Visible = false;
                sec.Visible = false;

                score.Visible = false;
                label1.Visible = false;

                m = 2;
                MessageBox.Show("Quiz Finish Your score : "+Score);
               D = 0;
                C = 0;
                A = 0;
                Score = 0;
            }

        }
    }
}
