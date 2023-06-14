namespace ProFitApplication.Views.WeightTraining;

public partial class Squat : ContentPage
{
	public Squat()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Lunges));
    }
}