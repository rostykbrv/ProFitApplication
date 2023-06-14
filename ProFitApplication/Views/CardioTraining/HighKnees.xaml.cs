namespace ProFitApplication.Views.Exercises;

public partial class HighKnees : ContentPage
{
    public HighKnees()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
         await Shell.Current.GoToAsync(nameof(RunningPlace));
    }
}