using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
        [Serializable]
        public class ExerciseEntry
        {
            public string ExerciseName { get; set; }
            public int Repetitions { get; set; }
            public string Name { get; set; }

            public ExerciseEntry() { }

            public ExerciseEntry(string exerciseName, int repetitions, string name)
            {
                ExerciseName = exerciseName;
                Repetitions = repetitions;
                Name = name;
            }
        }

}

