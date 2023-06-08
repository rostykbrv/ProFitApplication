using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProFitApplication.Models;
using System.Collections.ObjectModel;
using ProFitApplication.Views;

namespace ProFitApplication.ViewModels
{
    [QueryProperty(nameof(Workout), "Gym")]
    public partial class GymWorkoutPageViewModel: BaseViewModel
    {
        public ObservableCollection<ExerciseGroup> ExerciseGroups { get; set; }

        public GymWorkoutPageViewModel()
        {
            ExerciseGroups = new ObservableCollection<ExerciseGroup>
            {
                new ExerciseGroup
                {
                    ExerciseGroupName = "Cилове тренування",
                    ExerciseGroupDescription = "Група вправ, розроблена для підвищення м'язової сили і зміцнення тіла. Цей тренувальний комплекс допоможе вам розвивати і зміцнювати ваші м'язи, покращити стійкість та підвищити загальний рівень фізичної форми.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "gym_strenth_training.jpg",
                    ExerciseGroupKcal = "400",
                    ExerciseGroupTimeSpent = "60"

                },
                new ExerciseGroup
                {
                    ExerciseGroupName = "Тренування ніг",
                    ExerciseGroupDescription = "Ця група вправ призначена для розвитку та зміцнення м'язів ніг, покращення міцності, стійкості та здатності до збалансованого руху.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "gym_leg_training.jpg",
                    ExerciseGroupKcal = "300",
                    ExerciseGroupTimeSpent = "45"

                },
                 new ExerciseGroup
                {
                    ExerciseGroupName = "Тренування верхньої частини тіла",
                    ExerciseGroupDescription = "Тренування верхньої частини тіла спрямоване на розвиток та зміцнення м'язів плечей, спини, грудей та рук. Ця група вправ допоможе вам покращити силу верхньої частини тіла, збільшити стійкість та відмінно працювати над фізичною формою.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "gym_upperbody_training.jpg",
                    ExerciseGroupKcal = "300",
                    ExerciseGroupTimeSpent = "60"

                },
                 new ExerciseGroup
                {
                    ExerciseGroupName = "Тренування рук",
                    ExerciseGroupDescription = "Тренування спрямоване на зміцнення м'язів рук, плечового поясу та верхньої частини тіла загалом.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "gym_arms_training.jpg",
                    ExerciseGroupKcal = "310",
                    ExerciseGroupTimeSpent = "60"

                }
            };
        }
    }
}
