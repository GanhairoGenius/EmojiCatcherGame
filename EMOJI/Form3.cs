using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMOJI
{
    public partial class Form3 : Form
        
    {
        public static Form3 instance;
        public Label lb1;
        int seconds;
        int Points = 0;
        Random rnd = new Random();


        public Form3()
        {
            InitializeComponent();
            instance = this;
            lb1 = label1;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            instance.Size = new Size(900, 608);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Points++;
            label5.Text = Points.ToString();
            int x = rnd.Next(10, 100);
            int y = rnd.Next(10, 100);
            pictureBox1.Location = new Point(x, y);
       
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if(radioButton1.Checked == true)
            { seconds = 30;
              radioButton2.Enabled=false;
              radioButton3.Enabled=false;
            }
            else if(radioButton2.Checked == true)
            { seconds = 20;
              radioButton1.Enabled=false;
              radioButton3.Enabled=false;
                pictureBox1.Size = new System.Drawing.Size(90, 90);
                pictureBox2.Size = new System.Drawing.Size(90, 90);
                pictureBox3.Size = new System.Drawing.Size(90, 90);
            }

            else if(radioButton3.Checked == true)
            { seconds = 10; 
             radioButton1.Enabled=false;
             radioButton3.Enabled=false;
                pictureBox1.Size = new System.Drawing.Size(50, 50);
                pictureBox2.Size = new System.Drawing.Size(50, 50);
                pictureBox3.Size = new System.Drawing.Size(50, 50);
            }

            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = seconds--.ToString();
            if(seconds < 0) 
            {
              timer1.Stop();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            instance.Size = new Size(993, 608);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            instance.Size = new Size(1136, 608);
        }
    }
}
