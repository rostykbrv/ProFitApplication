namespace ProFitApplication.Views.UpperBodyTraining;

public partial class PushUp : ContentPage
{
	public PushUp()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PikePushUps));
    }
}