namespace ProFitApplication.Views.UpperBodyTraining;

public partial class PlankUpperBody : ContentPage
{
    int circle = 0;
	public PlankUpperBody()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        if (circle < 2)
        {
            circle++;
            await Shell.Current.GoToAsync(nameof(PushUp));
        }
        else
            await Shell.Current.GoToAsync(nameof(SuccessWorkoutDone));
    }
}