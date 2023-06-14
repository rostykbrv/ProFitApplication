namespace ProFitApplication.Views.LowerBodyTraining;

public partial class GluteBridges : ContentPage
{
	public GluteBridges()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SquatReach));
    }
}