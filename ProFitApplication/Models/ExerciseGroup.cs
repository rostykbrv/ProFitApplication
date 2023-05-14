using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFitApplication.Models
{
    public class ExerciseGroup
    {
        public string ExerciseGroupName { get; set; }
        public string ExerciseGroupDescription { get; set; }
        public string ExerciseGroupImage { get; set; }
        public string ExerciseGroupLevel { get; set; }

        public string ExerciseGroupKcal { get; set; }

        public string ExerciseGroupTimeSpent { get; set; }

        public ObservableCollection<Exercise> Exercises { get; set; }   
    }
}
