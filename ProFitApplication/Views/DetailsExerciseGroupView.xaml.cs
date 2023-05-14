using CommunityToolkit.Mvvm.ComponentModel;
using ProFitApplication.Models;
using ProFitApplication.Views;
using ProFitApplication.ViewModels;

namespace ProFitApplication.Views;

public partial class DetailsExerciseGroupView : ContentPage
{
	public DetailsExerciseGroupView(DetailsExerciseGroupViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}

    /*private async void StartButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExercisingPageView());
    }*/

    /*private async void ButtonStart_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ExercisingPageView());
    }*/
}