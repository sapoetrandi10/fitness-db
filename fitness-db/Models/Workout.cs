using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_db.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutID { get; set; }
        public string WorkoutName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; } = 0;
        public float CaloriesBurned { get; set; } = 0;


        public ICollection<UserWorkout> UserWorkouts { get; set; }
    }
}
