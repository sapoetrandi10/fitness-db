﻿using System;
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
        public DateTime ProgressDate { get; set; } = DateTime.UtcNow;
        public float Weight { get; set; } = 0;
        public float CaloriesConsumed { get; set; } = 0;
        public float CaloriesBurned { get; set; } = 0;


        public User User { get; set; }
    }
}
