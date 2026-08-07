using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectIRON.Views
{
    public partial class WeightSuccessView : UserControl
    {
        public WeightSuccessView()
        {
            InitializeComponent();
        }

        public event EventHandler? HomeRequested;
        public event EventHandler? LogAnotherWeightRequested;

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            HomeRequested?.Invoke(this, EventArgs.Empty);
        }

        private void LogAnotherButton_Click(object sender, RoutedEventArgs e)
        {
            LogAnotherWeightRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}