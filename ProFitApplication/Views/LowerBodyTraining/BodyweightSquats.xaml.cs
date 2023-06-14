namespace ProFitApplication.Views.LowerBodyTraining;

public partial class BodyweightSquats : ContentPage
{
	public BodyweightSquats()
	{
		InitializeComponent();
	}


    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Walking_Lunges));
    }
}