using ProjectIRON.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectIRON
{
    public partial class WeightView : UserControl
    {
        public WeightView()
        {
            InitializeComponent();
        }

        public event EventHandler? BackRequested;
        public event EventHandler? WeightSaved;
        public event EventHandler? HistoryRequested;


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(WeightTextBox.Text, out double weight)
                || weight <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid weight greater than zero.",
                    "Invalid Weight",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                return;
            }

            ComboBoxItem selectedUnit =
                (ComboBoxItem)WeightUnitComboBox.SelectedItem;

            string weightUnit = selectedUnit.Content.ToString()!;

            WeightLog weightLog = new WeightLog
            {
                Weight = weight,
                WeightUnit = weightUnit,
                Date = DateTime.Now
            };

            WeightSaved?.Invoke(this, EventArgs.Empty);
        }


        private void ViewHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            HistoryRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
