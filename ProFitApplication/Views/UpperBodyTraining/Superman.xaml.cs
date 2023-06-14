namespace ProFitApplication.Views.UpperBodyTraining;

public partial class Superman : ContentPage
{
	public Superman()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PlankUpperBody));
    }
}
