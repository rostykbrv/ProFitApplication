using ProFitApplication.Models;
using ProFitApplication.ViewModels;

namespace ProFitApplication.Views;

public partial class HomeWorkoutPageView : ContentPage
{
	public HomeWorkoutPageView(HomeWorkoutPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
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