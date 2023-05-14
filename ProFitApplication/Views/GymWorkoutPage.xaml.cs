using ProFitApplication.ViewModels;

namespace ProFitApplication.Views;

public partial class GymWorkoutPage : ContentPage
{
	public GymWorkoutPage(GymWorkoutPageViewModel gymWorkoutPageViewModel)
	{
		InitializeComponent();
		BindingContext=gymWorkoutPageViewModel;
	}
}