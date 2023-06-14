namespace ProFitApplication.Views.KhathaYoga;

public partial class MatsyasanaFishPose : ContentPage
{
	public MatsyasanaFishPose()
	{
		InitializeComponent();
	}
    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Sukhasan));
    }
}