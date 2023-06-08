namespace ProFitApplication.Views.LowerBodyTraining;

public partial class Walking_Lunges : ContentPage
{
	public Walking_Lunges()
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
        await Shell.Current.GoToAsync(nameof(GluteBridges));
    }
}