using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Натисніть кнопку “Ок”!!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка “Ок” була натиснута");
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int w = button1.Size.Width;
            int h = button1.Size.Height;
            Random x = new Random();
            Random y = new Random();
            int xx = Convert.ToInt32(x.Next(100, 250));
            int yy = Convert.ToInt32(y.Next(150, 300));
            button1.Location = new Point(xx, yy);
            this.button1.Size = new System.Drawing.Size(w - 3, h - 3);
            if (w < 3 || h < 3)
            {
                MessageBox.Show("Кнопка “Ок” не може бути натиснута");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
