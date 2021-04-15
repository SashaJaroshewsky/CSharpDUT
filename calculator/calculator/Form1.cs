using System;

using System.Drawing;

using System.Windows.Forms;

namespace calculator
{
    
    public partial class Form1 : Form
    {
        

        Class1 cl1 = new Class1();
        Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17;
        double a;
        double b;
        double c;
        TextBox textBox1;
        char znak = '+';
       
        public Form1()
        {
           
            textBox1 = new TextBox();
            Controls.Add(textBox1);
            SuspendLayout();
            textBox1.BackColor = SystemColors.ControlDarkDark;
            textBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            textBox1.ForeColor = Color.GhostWhite;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(146, 26);
            textBox1.TabIndex = 16;
            textBox1.TextAlign = HorizontalAlignment.Right;

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 258);

            Name = "Form1";
            Text = "calculator";
            HelpButton = false;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
            cl1.CreateMyButton(btn10, this, "/", 167, 104, 40, 40, Click_My_Button);
           cl1.CreateMyButton(btn11, this, "*", 167, 154, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn12, this, "-", 167, 204, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn13, this, "+", 167, 254, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn14, this, "=", 114, 254, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn15, this, ".", 64, 254, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn16, this, "+/-", 14, 60, 80, 38, Click_My_Button);
            cl1.CreateMyButton(btn17, this, "C", 129, 60, 80, 38, Click_My_Button);
           cl1.CreateMyButton(btn1, this, "1", 14, 204, 40, 40, Click_My_Button);
           cl1.CreateMyButton(btn2, this, "2", 64, 204, 40, 40, Click_My_Button);
           cl1.CreateMyButton(btn3, this, "3", 114, 204, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn4, this, "4", 14, 154, 40, 40, Click_My_Button);
           cl1.CreateMyButton(btn5, this, "5", 64, 154, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn6, this, "6", 114, 154, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn7, this, "7", 14, 104, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn8, this, "8", 64, 104, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn9, this, "9", 114, 104, 40, 40, Click_My_Button);
            cl1.CreateMyButton(btn0, this, "0", 14, 254, 40, 40, Click_My_Button);
        }
        public void Click_My_Button(object sender, EventArgs e)
        {
            
            if((sender as Button).Text == "0"||
                (sender as Button).Text == "1"||
                (sender as Button).Text == "2" ||
                (sender as Button).Text == "3" ||
                (sender as Button).Text == "4" ||
                (sender as Button).Text == "5" ||
                (sender as Button).Text == "6" ||
                (sender as Button).Text == "7" ||
                (sender as Button).Text == "8" ||
                (sender as Button).Text == "9" ||
                (sender as Button).Text == "." )
                
            {
                
                textBox1.Text += (sender as Button).Text;
            }
            if ((sender as Button).Text == "+" ||
                (sender as Button).Text == "-" ||
                (sender as Button).Text == "*" ||
                (sender as Button).Text == "/" 
                )
            {
                if (textBox1.Text != "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    znak = (sender as Button).Text[0];
                    textBox1.Clear();
                }
                else
                {
                    textBox1.Clear();
                }
               
            }
            if((sender as Button).Text == "=")
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case '*':
                        c = a * b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                }
                textBox1.Text = c.ToString();
            }
            if((sender as Button).Text == "C")
            {
                textBox1.Clear();
            }
            if ((sender as Button).Text == "+/-")
            {
                if (textBox1.Text != "")
                    if (textBox1.Text[0] == '-')
                        textBox1.Text = textBox1.Text.Remove(0, 1);
                    else textBox1.Text = '-' + textBox1.Text;
            }
        }


    }
}
