using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFitApplication.Services
{
    public interface INavigationService
    {
        Task NavigationToAsync(string route,IDictionary<string, object> parameters=null);
    }
}
