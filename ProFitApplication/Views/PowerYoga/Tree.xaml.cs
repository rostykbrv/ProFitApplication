namespace ProFitApplication.Views.PowerYoga;

public partial class Tree : ContentPage
{
	public Tree()
	{
		InitializeComponent();
	}

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Warrior));
    }
}