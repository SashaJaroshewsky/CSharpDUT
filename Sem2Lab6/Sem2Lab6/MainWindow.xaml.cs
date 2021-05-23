using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Sem2Lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 1); ;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private byte blink = 1;
        private bool show = false;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.show)
            {
                this.Title = "Нажміть на кнопку ОК!!!";
                this.show = false;
            }
            else
            {
                this.Title = "";
                this.show = true;
            }
            ++this.blink;
            if (this.blink <= (byte)16)
                return;
            this.timer.Stop();
            this.show = false;
        }
        private static readonly Random random = new Random();
        private void button1_Move(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Canvas.SetLeft(button, random.Next(100, 300));
            Canvas.SetTop(button, random.Next(100, 250));
            button.Width -= 3;
            button.Height -= 3;

            if (button1.Height <= 0)
            {
                MessageBox.Show("Кнопка OK зникла назавжди(Злий сміх)");
                this.timer.Stop();
                this.show = false;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ви все таки натиснули цю злу кнопку");
        }



    }
}
