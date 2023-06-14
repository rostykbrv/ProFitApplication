using ProFitApplication.Views.Exercises;

namespace ProFitApplication.Views.LowerBodyTraining;

public partial class LungesJump : ContentPage
{
	public LungesJump()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HighKnees));
    }
}