namespace ProFitApplication.Views.PowerYoga;

public partial class Warrior : ContentPage
{
	public Warrior()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Sumo));
    }
}