namespace SleepNavIssue;

public partial class NewPage1 : ContentPage
{
    bool isBusy;

	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Dispatcher.DispatchAsync(async () =>
        {
            if (isBusy)
                return;            
            isBusy = true;
            
            await Navigation.PopModalAsync();
            isBusy = false;
        });
    }
}