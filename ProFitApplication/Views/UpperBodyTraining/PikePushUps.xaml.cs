namespace ProFitApplication.Views.UpperBodyTraining;

public partial class PikePushUps : ContentPage
{
	public PikePushUps()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DiamondPushUps));
    }
}