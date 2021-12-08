using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brigadires
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
            label4.Text = "Дата: " + DateTime.Now.ToString("MM/dd/yy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
