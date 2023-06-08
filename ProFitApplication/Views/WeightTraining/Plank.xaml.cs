namespace ProFitApplication.Views.WeightTraining;

public partial class Plank : ContentPage
{
    int circle = 0;
    public Plank()
	{
		InitializeComponent();
    }

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        if (circle < 2)
        {
            circle++;
            await Shell.Current.GoToAsync(nameof(Squat));
        }
        else
            await Shell.Current.GoToAsync(nameof(SuccessWorkoutDone));
    }
}