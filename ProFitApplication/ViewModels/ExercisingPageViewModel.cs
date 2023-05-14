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
        private Exercise _selecedProgram;
        public ObservableCollection<Exercise> Exercises { get; set; }
        public ExercisingPageViewModel()
        {
            Exercises = new ObservableCollection<Exercise>
            {
                new Exercise
                {
                     ExerciseName = "Джампінг джек",
                     ExerciseGif = "jumpingjack.gif",
                     ExerciseRules = "Стійте прямо, руки вздовж тіла.\r\nПідскочіть та одночасно розведіть руки в сторони над головою.\r\nПід час повернення назад, руки опустіть вздовж тіла та поверніть стопи в початкове положення."
                },
                new Exercise
                {
                    ExerciseName="22",
                    ExerciseGif="jumpingjack.gif",
                    ExerciseRules="chill"
                }
            };
            
        }

    }
}
