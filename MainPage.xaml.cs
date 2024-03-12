namespace SleepNavIssue
{
    public partial class MainPage : ContentPage
    {

        bool isBusy;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Dispatcher.DispatchAsync(async () =>
            {
                if (isBusy)
                    return;
                isBusy = true;
                CounterBtn.IsEnabled = !isBusy;
                await Task.Delay(3000);
                await Navigation.PushModalAsync(new NewPage1());
                isBusy = false;
                CounterBtn.IsEnabled = !isBusy; 
            });
        }
    }

}
