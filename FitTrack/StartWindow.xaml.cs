using FitTrack.Classes.BaseClasses;
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

namespace FitTrack
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        UserManagement manager;
        public StartWindow(UserManagement manager)
        {
            
            InitializeComponent();
            this.manager = manager;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow(manager);
            loginWindow.Show();
            this.Close();


        }
    }
}
