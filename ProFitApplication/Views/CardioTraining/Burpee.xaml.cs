namespace ProFitApplication.Views.Exercises;

public partial class Burpee : ContentPage
{
    int circle = 0;
    public Burpee()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        if (circle < 2)
        {
            circle++;
            await Shell.Current.GoToAsync(nameof(JumpingJackPage));
        }else
            await Shell.Current.GoToAsync(nameof(SuccessWorkoutDone));
    }
}