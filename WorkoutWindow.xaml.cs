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
using System.Windows.Shapes;

using System.Windows;

namespace ProjectIRON
{
    public partial class WorkoutWindow : Window
    {
        public WorkoutWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Workout myWorkout = new Workout();

            myWorkout.Exercise = ExerciseTextBox.Text;
            myWorkout.Sets = int.Parse(SetsTextBox.Text);
            myWorkout.Reps = int.Parse(RepsTextBox.Text);
            myWorkout.Weight = double.Parse(WeightTextBox.Text);
            myWorkout.Date = DateTime.Now;

            MessageBox.Show(
                $"Exercise: {myWorkout.Exercise}\n" +
                $"Sets: {myWorkout.Sets}\n" +
                $"Reps: {myWorkout.Reps}\n" +
                $"Weight: {myWorkout.Weight}\n" +
                $"Date: {myWorkout.Date}",
                "Workout Saved Successfully"
            );

            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
