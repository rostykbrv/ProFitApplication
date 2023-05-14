using ProFitApplication.Views;

namespace ProFitApplication;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new AppShell();
	}

   
}
