
namespace ProFitApplication.Views.Exercises;

public partial class JumpingJackPage : ContentPage
{

	public JumpingJackPage()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HighKnees));
    }
}