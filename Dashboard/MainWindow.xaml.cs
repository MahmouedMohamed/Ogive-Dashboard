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

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if(Application.Current.MainWindow.Height == System.Windows.SystemParameters.PrimaryScreenHeight)
            {
                Application.Current.MainWindow.Height = 600;
                Application.Current.MainWindow.Width = 1024;
                return;
            }
            Application.Current.MainWindow.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            Application.Current.MainWindow.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var dialog = new Dialog();
            if (dialog.ShowDialog() == true)
            {
                MessageBox.Show("You said: " + dialog.ResponseText);
            }
        }
    }
}
