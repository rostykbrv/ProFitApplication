using ProFitApplication.ViewModels;

namespace ProFitApplication.Views;

public partial class YogaPageView : ContentPage
{
	public YogaPageView(YogaPageViewModel yogaPageViewModel)
	{
		InitializeComponent();
		BindingContext=yogaPageViewModel;
	}
}