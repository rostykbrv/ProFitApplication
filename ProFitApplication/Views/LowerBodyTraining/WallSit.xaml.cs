namespace ProFitApplication.Views.LowerBodyTraining;

public partial class WallSit : ContentPage
{
	int circle = 0;
	public WallSit()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        if (circle < 2)
        {
            circle++;
            await Shell.Current.GoToAsync(nameof(BodyweightSquats));
        }
        else
            await Shell.Current.GoToAsync(nameof(SuccessWorkoutDone));
    }
}