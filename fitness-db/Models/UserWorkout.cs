using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitness_db.Models
{
    public class UserWorkout
    {
        [Key]
        public int UserWorkoutID { get; set; }
        public int UserID { get; set; }
        public int WorkoutID { get; set; }
        public int WorkoutDuration { get; set; }
        public DateTime UserWorkoutDate { get; set; } = DateTime.Now;


        public User User { get; set; }

        public Workout Workout { get; set; }
    }
}
