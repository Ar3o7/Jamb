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
using System.Windows.Shapes;

namespace Jamb
{
    /// <summary>
    /// Interaction logic for MainManue.xaml
    /// </summary>
    public partial class MainManue : Window
    {
        public MainManue()
        {
            InitializeComponent();
        }

        private void Yamb_thing_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
