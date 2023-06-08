using ProFitApplication.ViewModels;
using ProFitApplication.Models;

namespace ProFitApplication.Views;

public partial class YogaPageView : ContentPage
{
	public YogaPageView(YogaPageViewModel yogaPageViewModel)
	{
		InitializeComponent();
		BindingContext=yogaPageViewModel;
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