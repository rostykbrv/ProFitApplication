namespace ProFitApplication.Views.PowerYoga;

public partial class SixPoints : ContentPage
{
	public SixPoints()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Triangle));
    }
}