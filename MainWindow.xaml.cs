using System.Windows;

namespace ProjectIRON
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ShowHomeView();
        }

        private void ShowHomeView()
        {
            HomeView homeView = new HomeView();

            homeView.LogWorkoutRequested += HomeView_LogWorkoutRequested;

            MainContent.Content = homeView;
        }

        private void ShowWorkoutView()
        {
            WorkoutView workoutView = new WorkoutView();

            workoutView.BackRequested += WorkoutView_BackRequested;

            MainContent.Content = workoutView;
        }

        private void HomeView_LogWorkoutRequested(object? sender, EventArgs e)
        {
            ShowWorkoutView();
        }

        private void WorkoutView_BackRequested(object? sender, EventArgs e)
        {
            ShowHomeView();
        }

        private void WeightButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "The feature is currently under development. Check Back Later!",
                "Project IRON",
                MessageBoxButton.OK,
                MessageBoxImage.Information
             );
        }

        private void WorkoutButton_Click( object sender, RoutedEventArgs e)
        {
            WorkoutWindow workoutWindow = new WorkoutWindow();

            workoutWindow.Owner = this;

            workoutWindow.ShowDialog();
        }

        private void ViewLogsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "The feature is currently under development. Check Back Later!",
                "Project IRON",
                MessageBoxButton.OK,
                MessageBoxImage.Information
             );
        }

        private void ExitButton_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}