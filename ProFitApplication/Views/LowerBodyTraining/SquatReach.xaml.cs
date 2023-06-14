namespace ProFitApplication.Views.LowerBodyTraining;

public partial class SquatReach : ContentPage
{
	public SquatReach()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(WallSit));
    }
}