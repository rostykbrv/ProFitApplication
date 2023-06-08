namespace ProFitApplication.Views.WeightTraining;

public partial class Crunches : ContentPage
{
	public Crunches()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Plank));
    }
}