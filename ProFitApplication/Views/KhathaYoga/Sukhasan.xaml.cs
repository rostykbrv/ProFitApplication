namespace ProFitApplication.Views.KhathaYoga;

public partial class Sukhasan : ContentPage
{
	int circle = 0;
	public Sukhasan()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        if (circle < 2)
        {
            circle++;
            await Shell.Current.GoToAsync(nameof(DiamondAsan));
        }
        else
            await Shell.Current.GoToAsync(nameof(SuccessWorkoutDone));
    }
}