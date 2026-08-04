using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectIRON
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        public event EventHandler? LogWeightRequested;

        private void LogWeightButton_Click(object sender, RoutedEventArgs e)
        {
            LogWeightRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? LogWorkoutRequested;

        private void LogWorkoutButton_Click(object sender, RoutedEventArgs e)
        {
            LogWorkoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void ViewLogsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "The Logs feature is still under development.",
                "Coming Soon"
            );
        }
    }
}
