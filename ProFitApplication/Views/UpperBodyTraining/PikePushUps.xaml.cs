namespace ProFitApplication.Views.UpperBodyTraining;

public partial class PikePushUps : ContentPage
{
	public PikePushUps()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(100);
        imgLoader.IsAnimationPlaying = true;
    }

    private async void NextExercise_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DiamondPushUps));
    }
}