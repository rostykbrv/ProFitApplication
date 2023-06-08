using CommunityToolkit.Mvvm.ComponentModel;
using ProFitApplication.Models;
using ProFitApplication.Views.Exercises;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
