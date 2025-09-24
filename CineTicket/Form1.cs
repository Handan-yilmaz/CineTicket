using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int totalcase = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int water, tea, popcorn, coffee, cola, ticket, total;

            water = Convert.ToInt16(textBox1.Text);
            tea=Convert.ToInt16(textBox2.Text);
            popcorn=Convert.ToInt16(textBox3.Text);
            coffee=Convert.ToInt16(textBox4.Text);
            cola=Convert.ToInt16(textBox5.Text);
            ticket=Convert.ToInt16(textBox6.Text);

            total= water * 15 + tea * 20 + popcorn * 150 + coffee * 150 + cola * 80 + ticket * 220;

            labeltotal.Text = total.ToString() + " TL ";

        }

        private void labeltotal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
            textBox2.Text = "";
            textBox3.Text = ""; 
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox3.Focus();

        }
    }
}
