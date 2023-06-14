namespace ProFitApplication.Views.UpperBodyTraining;

public partial class ChairDips : ContentPage
{
	public ChairDips()
	{
		InitializeComponent();
	}
    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Superman));
    }
}