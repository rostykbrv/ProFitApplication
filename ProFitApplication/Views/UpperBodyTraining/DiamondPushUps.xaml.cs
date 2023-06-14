namespace ProFitApplication.Views.UpperBodyTraining;

public partial class DiamondPushUps : ContentPage
{
	public DiamondPushUps()
	{
		InitializeComponent();
	}
    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChairDips));
    }
}