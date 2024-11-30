using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_roller
{
    public partial class Form1 : Form
    {
        public string mod { get; set; }
        public string num { get; set; }
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            num = number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
           string mody = textBox1.Text;
            mod = mody;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            for (int x = 0; x < repeats; x++)
            {
                sum = sum + rand.Next(1, 5);
            
            
            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            for (int x = 0; x < repeats; x++)
            {
                sum = sum + rand.Next(1, 7);


            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            for (int x = 0; x < repeats; x++)
            {
                sum = sum + rand.Next(1, 9);


            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            for (int x = 0; x < repeats; x++)
            {
                sum = sum + rand.Next(1, 11);


            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            for (int x = 0; x < repeats; x++)
            {
                sum = sum + rand.Next(1, 13);


            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            int roll = 0;
            for (int x = 0; x < repeats; x++)
            {
                roll = rand.Next(1, 21);
                sum = sum + roll;
                
                


            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int modifier = Convert.ToInt32(mod);
            int repeats = Convert.ToInt32(num);
            int sum = 0;
            for (int x = 0; x < repeats; x++)
            {
                sum = sum + rand.Next(1, 101);


            }
            sum = sum + modifier;
            MessageBox.Show(sum + " is your total roll");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
   
}
