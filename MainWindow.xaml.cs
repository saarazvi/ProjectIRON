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
            homeView.LogWeightRequested += HomeView_LogWeightRequested;

            MainContent.Content = homeView;
        }

        private void ShowWeightView()
        {
            WeightView weightView = new WeightView();

            weightView.BackRequested += WeightView_BackRequested;
            weightView.WeightSaved += WeightView_WeightSaved;
            weightView.HistoryRequested += WeightView_HistoryRequested;

            MainContent.Content = weightView;
        }

        private void ShowWeightHistoryView()
        {
            WeightHistoryView historyView = new WeightHistoryView();

            historyView.BackRequested += WeightHistoryView_BackRequested;

            MainContent.Content = historyView;
        }

        private void WeightView_HistoryRequested(object? sender, EventArgs e)
        {
            ShowWeightHistoryView();
        }

        private void WeightHistoryView_BackRequested(object? sender, EventArgs e)
        {
            ShowWeightView();
        }

        private void HomeView_LogWeightRequested(object? sender, EventArgs e)
        {
            ShowWeightView();
        }

        private void WeightView_BackRequested(object? sender, EventArgs e)
        {
            ShowHomeView();
        }

        private void WeightView_WeightSaved(object? sender, EventArgs e)
        {
            ShowHomeView();
        }

        private void ShowWorkoutView()
        {
            WorkoutView workoutView = new WorkoutView();

            workoutView.BackRequested += WorkoutView_BackRequested;
            workoutView.WorkoutSaved += WorkoutView_WorkoutSaved;
            workoutView.HistoryRequested += WorkoutView_HistoryRequested;

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

        private void ShowSuccessView()
        {
            SuccessView successView = new SuccessView();

            successView.HomeRequested += SuccessView_HomeRequested;
            successView.LogAnotherWorkoutRequested +=
                SuccessView_LogAnotherWorkoutRequested;

            MainContent.Content = successView;
        }

        private void WorkoutView_WorkoutSaved(object? sender, EventArgs e)
        {
            ShowSuccessView();
        }

        private void SuccessView_HomeRequested(object? sender, EventArgs e)
        {
            ShowHomeView();
        }

        private void SuccessView_LogAnotherWorkoutRequested(
            object? sender,
            EventArgs e)
        {
            ShowWorkoutView();
        }

        private void ShowWorkoutHistoryView()
        {
            WorkoutHistoryView historyView = new WorkoutHistoryView();

            historyView.BackRequested += WorkoutHistoryView_BackRequested;

            MainContent.Content = historyView;
        }

        private void WorkoutView_HistoryRequested(object? sender, EventArgs e)
        {
            ShowWorkoutHistoryView();
        }

        private void WorkoutHistoryView_BackRequested(object? sender, EventArgs e)
        {
            ShowWorkoutView();
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