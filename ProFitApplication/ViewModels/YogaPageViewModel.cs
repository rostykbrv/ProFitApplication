using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProFitApplication.Models;


namespace ProFitApplication.ViewModels
{
    [QueryProperty(nameof(Workout), "Yoga")]
    public partial class YogaPageViewModel:BaseViewModel
    {
        public ObservableCollection<ExerciseGroup> ExerciseGroups { get; set; }

        public YogaPageViewModel()
        {
            ExerciseGroups = new ObservableCollection<ExerciseGroup>
            {
                new ExerciseGroup
                {
                    ExerciseGroupName = "Хатха-йога",
                    ExerciseGroupDescription = "Традиційний стиль йоги, який поєднує фізичні вправи (асани), дихальні вправи (пранаями) та медитацію для досягнення гармонії тіла і розуму.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "yoga1.jpg",
                    ExerciseGroupKcal = "200",
                    ExerciseGroupTimeSpent = "45"

                },
                new ExerciseGroup
                {
                    ExerciseGroupName = "Силовая йога",
                    ExerciseGroupDescription = "Стиль йоги, який поєднує рухи, силу, гнучкість та дихання. Цей стиль йоги побудований на основі вправ асан, що виконуються послідовно та ритмічно, допомагаючи покращити силу, витривалість, гнучкість та спритність.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "yoga2.jpg",
                    ExerciseGroupKcal = "250",
                    ExerciseGroupTimeSpent = "50"

                },
                 new ExerciseGroup
                {
                    ExerciseGroupName = "Аштанга-йога",
                    ExerciseGroupDescription = "Форма йоги, яка включає послідовні рухи, сполучені з диханням. Цей стиль йоги вимагає фізичної сили, гнучкості та витривалості, і базується на трьох основних складових: постійність практики, синхронізація рухів з диханням та фокус уваги.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "yoga3.jpg",
                    ExerciseGroupKcal = "210",
                    ExerciseGroupTimeSpent = "50"

                },
                new ExerciseGroup
                {
                    ExerciseGroupName = "Інь-йога",
                    ExerciseGroupDescription = "Стиль йоги, який фокусується на глибокому розслабленні та розтягуванні тканин, таких як сухожилля, зв'язки та фасції. У цьому стилі йоги асани (пози) утримуються на тривалому часі, зазвичай від 3 до 5 хвилин, з метою стимуляції гнучкості та енергетичного потоку в організмі.",
                    ExerciseGroupLevel = "Продвинутий",
                    ExerciseGroupImage = "yoga4.jpg",
                    ExerciseGroupKcal = "200",
                    ExerciseGroupTimeSpent = "40"

                }
            };
        }
    }
}
