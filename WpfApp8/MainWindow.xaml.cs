using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private DispatcherTimer dispatcherTimer;
        private int x_seconds_external = 15000;

        public MainWindow()
        {

            InitializeComponent();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            //dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Interval = TimeSpan.FromTicks(1);
            dispatcherTimer.Start();
        }
         
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            label1.Content = String.Format("{0:00}", x_seconds_external);
            x_seconds_external--;




            if (x_seconds_external < 15000)
            {
                Red.Fill = Brushes.Red;
                Green.Fill = new SolidColorBrush(Color.FromRgb(9, 95, 47));
                Yellow.Fill = new SolidColorBrush(Color.FromRgb(193, 173, 42));
            }
            if (x_seconds_external < 10500)
            {
                Red.Fill = Brushes.Red;
                Yellow.Fill = Brushes.Yellow;
            }
            if (x_seconds_external < 10000)
            {
                Red.Fill = new SolidColorBrush(Color.FromRgb(160, 34, 34));
                Green.Fill = new SolidColorBrush(Color.FromRgb(9, 95, 47));
            }

            if (x_seconds_external < 9000)
            {
                Green.Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                Yellow.Fill = new SolidColorBrush(Color.FromRgb(193, 173, 42));
            }

            
            if (x_seconds_external < 4000)
            {
                Red.Fill = new SolidColorBrush(Color.FromRgb(160, 34, 34));
                Yellow.Fill = Brushes.Yellow;
                Green.Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));

            }
            if (x_seconds_external < 3000)
            {
                x_seconds_external = 15000;
            }


        }


    }
    }


