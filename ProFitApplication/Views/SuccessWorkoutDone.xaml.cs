namespace ProFitApplication.Views;

public partial class SuccessWorkoutDone : ContentPage
{
	public SuccessWorkoutDone()
	{
		InitializeComponent();
	}

    private void OnMainButtonClicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(StartPageView));
    }
}