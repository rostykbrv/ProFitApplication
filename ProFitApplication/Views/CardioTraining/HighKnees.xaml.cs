namespace ProFitApplication.Views.Exercises;

public partial class HighKnees : ContentPage
{
    public HighKnees()
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
         await Shell.Current.GoToAsync(nameof(RunningPlace));
    }
}