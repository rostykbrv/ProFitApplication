using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ProFitApplication.Models;
using ProFitApplication.ViewModels;
using ProFitApplication.Services;
using System.Collections.ObjectModel;

namespace ProFitApplication.ViewModels
{
    [QueryProperty(nameof(Workout), "WorkoutHome")]
    public partial class HomeWorkoutPageViewModel : BaseViewModel
    {
        public ObservableCollection<ExerciseGroup> ExerciseGroups { get; set; }
        public HomeWorkoutPageViewModel()
        {
            ExerciseGroups = new ObservableCollection<ExerciseGroup>
            {
                new ExerciseGroup
                {
                    ExerciseGroupName = "Кардіо тренування",
                    ExerciseGroupDescription = "Кардіо тренування спрямовані на підвищення рівня витривалості і зниження ваги. Ці вправи базуються на використанні аеробної системи, що дозволяє виробляти енергію, використовуючи кисень.це ефективний спосіб зниження ваги і поліпшення здоров'я серцево-судинної системи.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "cardiotraining.jpeg",
                    ExerciseGroupKcal = "340",
                    ExerciseGroupTimeSpent = "20"

                },

                new ExerciseGroup
                {
                    ExerciseGroupName = "Силове тренування",
                    ExerciseGroupDescription = "Силове тренування спрямоване на підвищення м'язової сили, збільшення м'язової маси та поліпшення загального здоров'я. Ці вправи базуються на використанні опорно-рухової системи, що дозволяє збільшити навантаження на м'язи.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "strengthtraining.jpeg",
                    ExerciseGroupKcal = "240",
                    ExerciseGroupTimeSpent = "30"

                },

                new ExerciseGroup
                {
                    ExerciseGroupName = "Тренування верхньої частини тіла",
                    ExerciseGroupDescription = "Тренування верхньої частини тіла складається з вправ, які спрямовані на розвиток м'язів грудної клітки, спини, плечей та рук. Вправи допомагають зміцнити м'язи верхньої частини тіла та покращити стан м'язів, сприяють підвищенню тонусу та зміцненню кісток.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "upperbodytraining.jpeg",
                    ExerciseGroupKcal = "300",
                    ExerciseGroupTimeSpent = "35"
                },

                new ExerciseGroup
                {
                    ExerciseGroupName = "Тренування нижньої частини тіла",
                    ExerciseGroupDescription = "Тренування нижньої частини тіла: це програма, що складається з вправ, спрямованих на розвиток м'язів стегон, ягодиць та ніг. Ці вправи покращують координацію, збільшують мобільність та зміцнюють м'язи нижньої частини тіла.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "lowerbodytraining.jpeg",
                    ExerciseGroupKcal = "210",
                    ExerciseGroupTimeSpent = "30"
                }

            };

        }
    }
}
