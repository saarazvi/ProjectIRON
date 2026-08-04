using ProjectIRON.Models;
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

        public event EventHandler? WorkoutSaved;

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // 1. Exercise must not be blank
            string exercise = ExerciseTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(exercise))
            {
                MessageBox.Show(
                    "Please enter an exercise name.",
                    "Invalid Exercise",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                return;
            }

            // 2. Sets must be a whole number greater than zero
            if (!int.TryParse(SetsTextBox.Text, out int sets) || sets <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid number of sets greater than zero.",
                    "Invalid Sets",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                return;
            }

            // 3. Reps must be a whole number greater than zero
            if (!int.TryParse(RepsTextBox.Text, out int reps) || reps <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid number of reps greater than zero.",
                    "Invalid Reps",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                return;
            }

            // 4. Weight must be a valid number greater than zero
            if (!double.TryParse(WeightTextBox.Text, out double weight) || weight <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid weight greater than zero.",
                    "Invalid Weight",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                return;
            }

            // 5. Read selected unit
            ComboBoxItem selectedUnit =
                (ComboBoxItem)WeightUnitComboBox.SelectedItem;

            string weightUnit = selectedUnit.Content.ToString()!;

            // 6. Create the Workout only after all input is valid
            Workout myWorkout = new Workout();

            myWorkout.Exercise = exercise;
            myWorkout.Sets = sets;
            myWorkout.Reps = reps;
            myWorkout.Weight = weight;
            myWorkout.WeightUnit = weightUnit;
            myWorkout.Date = DateTime.Now;

            WorkoutSaved?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? HistoryRequested;

        private void ViewHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            HistoryRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
