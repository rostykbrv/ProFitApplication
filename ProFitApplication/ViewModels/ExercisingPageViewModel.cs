using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using ProFitApplication.Models;
using ProFitApplication.Views;

namespace ProFitApplication.ViewModels
{
    [QueryProperty(nameof(Exercise), "Exercise")]
    public partial class ExercisingPageViewModel:BaseViewModel
    {
        public ExercisingPageViewModel()
        {
           
        }

        [ObservableProperty]
        Exercise exercise;

    }
}
