using ProFitApplication.ViewModels;
using System.Reflection.Metadata;

namespace ProFitApplication.Views;

public partial class ExercisingPageView : ContentPage
{

    public ExercisingPageView(ExercisingPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    
}