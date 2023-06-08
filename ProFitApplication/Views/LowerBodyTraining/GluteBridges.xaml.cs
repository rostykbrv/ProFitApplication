namespace ProFitApplication.Views.LowerBodyTraining;

public partial class GluteBridges : ContentPage
{
	public GluteBridges()
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
        await Shell.Current.GoToAsync(nameof(WallSit));
    }
}