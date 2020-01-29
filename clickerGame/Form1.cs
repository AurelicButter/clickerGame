using System;
using System.Windows.Forms;

namespace clickerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "0";
            label4.Text = "0";
            label6.Text = "50";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(label2.Text);

            label2.Text = Convert.ToString(x + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var y = Convert.ToInt32(label2.Text);
            var z = Convert.ToInt32(label4.Text);
            int[] level = new int[] { 50, 100, 200, 400 };

            if (y >= level[z]) {
                label7.Text = "Level up! You are now Level " + Convert.ToString(z + 1);
                label4.Text = Convert.ToString(z + 1);
                label6.Text = Convert.ToString(level[z + 1]);
            } else {
                label7.Text = "Error: You don't have enough points yet!";
            }
        }
    }
}
