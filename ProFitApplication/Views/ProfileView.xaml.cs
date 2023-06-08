using ProFitApplication.Models;
using ProFitApplication.ViewModels;

namespace ProFitApplication.Views;

public partial class ProfileView : ContentPage
{
    public ProfileView(ProfileViewModel profileViewModel)
	{
		InitializeComponent();
		this.BindingContext= profileViewModel;
	}

}