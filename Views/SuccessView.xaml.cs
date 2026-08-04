using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectIRON
{
    public partial class SuccessView : UserControl
    {
        public SuccessView()
        {
            InitializeComponent();
        }

        public event EventHandler? HomeRequested;
        public event EventHandler? LogAnotherWorkoutRequested;

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomeRequested?.Invoke(this, EventArgs.Empty);
        }

        private void LogAnotherButton_Click(object sender, RoutedEventArgs e)
        {
            LogAnotherWorkoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}