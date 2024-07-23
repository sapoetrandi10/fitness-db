using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_db.Models
{
    public class UserNutrition
    {
        [Key]
        public int UserNutritionID { get; set; }
        public int UserID { get; set; }
        public int NutritionID { get; set; }
        public int Qty { get; set; }
        public DateTime UserNutritionDate { get; set; } = DateTime.Now;


        public User User { get; set; }

        public Nutrition Nutrition { get; set; }
    }
}
