using CommunityToolkit.Mvvm.ComponentModel;
using ProFitApplication.Models;
using ProFitApplication.Views;
using ProFitApplication.Views.Exercises;
using ProFitApplication.ViewModels;
using ProFitApplication.Views.WeightTraining;
using ProFitApplication.Views.UpperBodyTraining;
using ProFitApplication.Views.LowerBodyTraining;
using ProFitApplication.Views.KhathaYoga;
using ProFitApplication.Views.PowerYoga;

namespace ProFitApplication.Views;

public partial class DetailsExerciseGroupView : ContentPage
{   
    public DetailsExerciseGroupView(DetailsExerciseGroupViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}

    private async void Start_Clicked(object sender, EventArgs e)
    {
        var viewModel = (DetailsExerciseGroupViewModel)BindingContext;

        if (viewModel.ExerciseGroup != null)
        {
            switch (viewModel.ExerciseGroup.ExerciseGroupName)
            {
                case "����� ����������":
                    await Shell.Current.GoToAsync(nameof(JumpingJackPage));
                    break;
                case "������ ����������":
                    await Shell.Current.GoToAsync(nameof(Squat));
                    break;
                case "���������� ������� ������� ���":
                    await Shell.Current.GoToAsync(nameof(PushUp));
                    break;
                case "���������� ������ ������� ���":
                    await Shell.Current.GoToAsync(nameof(BodyweightSquats));
                    break;
                case "�����-����":
                    await Shell.Current.GoToAsync(nameof(DiamondAsan));
                    break;
                case "������ ����":
                    await Shell.Current.GoToAsync(nameof(SixPoints));
                    break;

                default:

                    break;
            }
        }
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