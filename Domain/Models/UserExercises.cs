﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class UserExercise
    {
        public Guid Id { get; set; }
        [Required]
        public Guid ExerciseId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public int MaxWeight { get; set; }
        public int BestTime { get; set; }
        [ForeignKey("ExerciseId")]
        public Exercise Exercise { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
