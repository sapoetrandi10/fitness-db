using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_db.Models
{
    public class Progress
    {
        [Key]
        public int ProgressID { get; set; }
        public int UserID { get; set; }
        public DateTime ProgressDate { get; set; }
        public float Weight { get; set; }
        public float CaloriesConsumed { get; set; }
        public float CaloriesBurned { get; set; }


        public User User { get; set; }
    }
}
