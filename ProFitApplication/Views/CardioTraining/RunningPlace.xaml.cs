namespace ProFitApplication.Views.Exercises;

public partial class RunningPlace : ContentPage
{
    public RunningPlace()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    { 
            await Shell.Current.GoToAsync(nameof(Burpee));
       
    }
}