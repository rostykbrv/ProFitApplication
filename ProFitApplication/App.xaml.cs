using ProFitApplication.Views;
using System.Net.WebSockets;

namespace ProFitApplication;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new AppShell();
		var loginPage= new LoginPage();
		MainPage.Navigation.PushAsync(loginPage);
	}
}
