using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ProFitApplication.Models;
using ProFitApplication.Views;
using ProFitApplication.Services;

namespace ProFitApplication.ViewModels
{
    public partial class StartPageViewModel
    {
        public ObservableCollection<Workout> Workouts { get; set; }
         
        public StartPageViewModel()
        {
            Workouts = new ObservableCollection<Workout>
            {
                new Workout
                {
                WorkoutImage="homeworkout.jpeg",
                WorkoutName="Тренування вдома",
                WorkoutsNumber="10+ Вправ"
                },
                new Workout
                {
                WorkoutImage="yoga.jpeg",
                WorkoutName="Йога",
                WorkoutsNumber="60+ Вправ"
                },
                new Workout
                {
                WorkoutImage="gym.jpeg",
                WorkoutName="Тренажерний зал",
                WorkoutsNumber="48+ Вправ"
                }
            };
        }

        
    }
}
