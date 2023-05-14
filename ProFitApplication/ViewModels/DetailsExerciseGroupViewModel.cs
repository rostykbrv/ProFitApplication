using CommunityToolkit.Mvvm.ComponentModel;
using ProFitApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFitApplication.ViewModels
{
    [QueryProperty(nameof(ExerciseGroup), "ExerciseGroup")]
    public partial class DetailsExerciseGroupViewModel:BaseViewModel
    {
        public DetailsExerciseGroupViewModel()
        {

        }

        [ObservableProperty]
        ExerciseGroup exerciseGroup;
    }


    
    
}
