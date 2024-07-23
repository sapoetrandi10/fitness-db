using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fitness_db.Models
{
    public class Nutrition
    {
        [Key]
        public int NutritionID { get; set; }
        public string NutritionName { get; set; }
        public float Calories { get; set; } = 0;
        public float Protein { get; set; } = 0;
        public float Carbs { get; set; } = 0;
        public float Fat { get; set; } = 0;


        public ICollection<UserNutrition> UserNutritions { get; set; }
    }
}
