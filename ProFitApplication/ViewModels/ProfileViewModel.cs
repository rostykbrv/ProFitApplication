using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProFitApplication.Models;

namespace ProFitApplication.ViewModels
{
    public class ProfileViewModel
    {
        public User User { get; set; }
        public ProfileViewModel()
        {
            if (Preferences.ContainsKey("User"))
            {
                var serializedUser = Preferences.Get("User", string.Empty);
                User = JsonSerializer.Deserialize<User>(serializedUser);
            }
        }

    }
}
