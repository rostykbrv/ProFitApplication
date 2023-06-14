namespace ProFitApplication.Views.WeightTraining;

public partial class PushUps : ContentPage
{
	public PushUps()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Crunches));
    }
}