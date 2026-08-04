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
    /// Interaction logic for WorkoutView.xaml
    /// </summary>
    public partial class WorkoutView : UserControl
    {
        public WorkoutView()
        {
            InitializeComponent();
        }

        public event EventHandler? BackRequested;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Workout myWorkout = new Workout();

            myWorkout.Exercise = ExerciseTextBox.Text;
            myWorkout.Sets = int.Parse(SetsTextBox.Text);
            myWorkout.Reps = int.Parse(RepsTextBox.Text);
            myWorkout.Weight = double.Parse(WeightTextBox.Text);

            ComboBoxItem selectedUnit =
                (ComboBoxItem)WeightUnitComboBox.SelectedItem;

            myWorkout.WeightUnit = selectedUnit.Content.ToString()!;
            myWorkout.Date = DateTime.Now;

            MessageBox.Show(
                $"Exercise: {myWorkout.Exercise}\n" +
                $"Sets: {myWorkout.Sets}\n" +
                $"Reps: {myWorkout.Reps}\n" +
                $"Weight: {myWorkout.Weight} {myWorkout.WeightUnit}\n" +
                $"Date: {myWorkout.Date:g}",
                "Workout Added Successfully",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}
