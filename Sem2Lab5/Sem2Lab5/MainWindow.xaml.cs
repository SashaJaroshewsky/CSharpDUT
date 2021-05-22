using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sem2Lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] btnArray = new Button[16];
        Button button1;
        public MainWindow()
        {
            InitializeComponent();
            //int y = 0, x = 0, n = 0;
            //for (int i = 0; i<16; i++)
            //{

            //    button1 = new Button();
            //    button1.Width = 30;
            //    button1.Height = 30;
            //    button1.Content = i.ToString();


            //    if (n == 4)
            //    {
            //        y += 70;
            //        n = 0;
            //        x = 0;
            //    }
            //    if (n < 4)
            //    {
            //        x += 70;
            //        n++;
            //    }
            //    else
            //    {
            //        n = 0;
            //        x = 70;
            //    }

            //    button1.Margin = new Thickness(x, y, 0, 0);
            //    btnArray[i] = button1;
            //}
            //for (int i = 0; i < 16; i++)
            //{
            //    Two.Content = btnArray[i];
            //}
                
            
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                comboBox.Items.Add(textbox.Text);
                textbox.Text = "";
            }
        }
        private void buttonDel_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Remove(comboBox.SelectedItem);
        }

        
    }
}
