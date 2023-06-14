namespace ProFitApplication.Views.WeightTraining;

public partial class Lunges : ContentPage
{
	public Lunges()
	{
		InitializeComponent();
	}


    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PushUps));
    }
}