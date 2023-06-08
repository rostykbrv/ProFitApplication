using ProFitApplication.Models;
using ProFitApplication.ViewModels;
using System.Collections.ObjectModel;

namespace ProFitApplication.Views;

public partial class StartPageView : ContentPage
{
    public StartPageView(StartPageViewModel startPageViewModel)
    {
        InitializeComponent();
        this.BindingContext = startPageViewModel;

    }
    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var workout = ((VisualElement)sender).BindingContext as Workout;
        if (workout == null)
            return;

        if (workout.WorkoutName == "Тренування вдома")
        {
            await Shell.Current.GoToAsync(nameof(HomeWorkoutPageView), true, new Dictionary<string, object>
        {
            {"HomeWorkout",workout }
        });
        }else if (workout.WorkoutName == "Йога")
        {
            await Shell.Current.GoToAsync(nameof(YogaPageView), true, new Dictionary<string, object>
        {
            {"Yoga",workout }
        });
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(GymWorkoutPage), true, new Dictionary<string, object>
        {
            {"Gym",workout }
        });
        }
    }
}