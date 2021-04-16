using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2_LB2
{
    public partial class Form1 : Form
    {
        TabControl tabControl1 = new TabControl();
        TabPage tabPage1 = new TabPage();
        TabPage tabPage2 = new TabPage();
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();
        ComboBox comboBox1 = new ComboBox();
        Button button2 = new Button();
        Button button1 = new Button();
        Button[] btnArray = new Button[16];
        Button button11 = new Button();
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            int y=0, x=0, n=0;
            for (int i = 0; i < btnArray.Length; i++)
            {
                
                Button buttonM = new Button();

                if (n==4)
                {
                    y += 70;
                    n = 0;
                    x = 0;
                }
                if (n < 4)
                {
                    x += 70;
                    n++;
                }
                else
                {
                    n = 0;
                    x = 70;
                }
                buttonM.Location = new Point(x, y);
                buttonM.Name = i.ToString();
                buttonM.Size = new Size(50, 50);
                buttonM.Text = i.ToString();
                buttonM.Click += new EventHandler(btnArray_Click);
                btnArray[i] = buttonM;
                tabPage2.Controls.Add(btnArray[i]);

            }
        }
        private void btnArray_Click(object sender, EventArgs e)
        {
            for(int i =0; i<btnArray.Length;i++)
            {
                if((sender as Button).Name == i.ToString())
                {
                    (sender as Button).Visible = false;
                    this.i++;
                }
            }
            if (i == 16)
            {
                textBox2.Text = "Ти виграв";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void Button1_2_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == this.button1.Name)
            {
                if (!(this.textBox1.Text != ""))
                    return;
                this.comboBox1.Items.Add((object)this.textBox1.Text);
                this.textBox1.Text = "";
            }
            else
            {
                if ((uint)this.comboBox1.Items.Count <= 0U)
                    return;
                this.comboBox1.Items.RemoveAt(this.comboBox1.Items.Count - 1);
            }
        }
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Coral;
            this.textBox1.Location = new System.Drawing.Point(6, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Chocolate;
            this.comboBox1.Location = new System.Drawing.Point(6, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(240, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати";
            this.button1.Click += new System.EventHandler(this.Button1_2_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(360, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Видалити";
            this.button2.Click += new System.EventHandler(this.Button1_2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 22);
            this.textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sem2_Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
