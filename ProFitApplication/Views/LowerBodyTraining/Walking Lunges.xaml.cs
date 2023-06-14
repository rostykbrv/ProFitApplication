namespace ProFitApplication.Views.LowerBodyTraining;

public partial class Walking_Lunges : ContentPage
{
	public Walking_Lunges()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GluteBridges));
    }
}