using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files(*.txt)|*.txt|all files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            textBox1.Text += sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string toProcess = textBox1.Text;

            char[] resultC = new char[textBox1.Text.Length];


            for (int i = 0; i < toProcess.Length; i++)
            {
                char c = (char)(toProcess[i] - 1);
                resultC[i] = c;
            }

            textBox2.Text = new string(resultC);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string toProcess = textBox1.Text;

            char[] resultC = new char[textBox1.Text.Length];


            for (int i = 0; i < toProcess.Length; i++)
            {
                char c = (char)(toProcess[i] + 1);
                resultC[i] = c;
            }

            textBox2.Text = new string(resultC);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files(*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            sw.Write(textBox2.Text);
                        }
                    }
                }
            }
        }
    }
}
