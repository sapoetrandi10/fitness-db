using System.ComponentModel.DataAnnotations;

namespace fitness_db.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }


        public ICollection<UserNutrition> UserNutritions { get; set; }
        public ICollection<UserWorkout> UserWorkouts { get; set; }
        public ICollection<Progress> Progresses { get; set; }
    }
}
