using ProFitApplication.Models;
using ProFitApplication.ViewModels;
using Microsoft.Maui.Storage;
using System.Text.Json;

namespace ProFitApplication.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Preferences.Default.Clear();
    }
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        if (!Preferences.ContainsKey("User"))
        {
            var user = new User();

            user.Name = nameEntry.Text;
            user.Age = int.Parse(ageEntry.Text);
            user.Weight = double.Parse(weightEntry.Text);
            user.Height = double.Parse(heightEntry.Text);

            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Pick your profile photo please",
                FileTypes = FilePickerFileType.Images
            });

            if (result == null)
                return;

            var stream = await result.OpenReadAsync();

            userPhoto.Source = ImageSource.FromStream(() => stream);

            var photoFilePath = result.FullPath;
            user.ProfilePhoto = photoFilePath;

            var serializedUser = JsonSerializer.Serialize(user);
            Preferences.Set("User", serializedUser);
        }

        await Shell.Current.GoToAsync(nameof(StartPageView));

    }
}