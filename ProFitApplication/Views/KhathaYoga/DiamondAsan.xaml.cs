namespace ProFitApplication.Views.KhathaYoga;

public partial class DiamondAsan : ContentPage
{
	public DiamondAsan()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MatsyasanaFishPose));
    }
}