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
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }


        public ICollection<UserNutrition> UserNutritions { get; set; }
    }
}
