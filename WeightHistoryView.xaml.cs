using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectIRON
{
    public partial class WeightHistoryView : UserControl
    {
        public WeightHistoryView()
        {
            InitializeComponent();
        }

        public event EventHandler? BackRequested;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}