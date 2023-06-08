using ProFitApplication.ViewModels;
using ProFitApplication.Models;

namespace ProFitApplication.Views;

public partial class GymWorkoutPage : ContentPage
{
	public GymWorkoutPage(GymWorkoutPageViewModel gymWorkoutPageViewModel)
	{
		InitializeComponent();
		BindingContext=gymWorkoutPageViewModel;
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var exerciseGroup = ((VisualElement)sender).BindingContext as ExerciseGroup;
        if (exerciseGroup == null)
            return;

        await Shell.Current.GoToAsync(nameof(DetailsExerciseGroupView), true, new Dictionary<string, object>
            {
            {"ExerciseGroup",exerciseGroup }
            });
    }
}