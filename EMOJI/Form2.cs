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
    public partial class Form2 : Form
    {
       
      
        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
            textBox1.MaxLength = 5;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            
            Form3.instance.lb1.Text = textBox1.Text;//to change label1 in form3
            if (textBox1.Text=="")
                MessageBox.Show("Please Enter Your Name");
            else
                 f3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          if(textBox1.Text.Length == 5) 
          {
                MessageBox.Show("Maximum characters is 5!!!");
            
          }
          
        }
    }
}
