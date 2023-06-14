namespace ProFitApplication.Views.PowerYoga;

public partial class Sumo : ContentPage
{
    int circle = 0;
	public Sumo()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        if (circle < 1)
        {
            circle++;
            await Shell.Current.GoToAsync(nameof(SixPoints));
        }
        else
            await Shell.Current.GoToAsync(nameof(SuccessWorkoutDone));
    }
}