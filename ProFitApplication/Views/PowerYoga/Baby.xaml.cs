namespace ProFitApplication.Views.PowerYoga;

public partial class Baby : ContentPage
{
	public Baby()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Tree));
    }
}