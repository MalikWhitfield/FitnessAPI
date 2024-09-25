using Domain.Enums;
using Domain.Models;

namespace Persistence
{
    public class SeedData
    {
        public static async Task CreateSeedData(DataContext context)
        {
            if (context.Exercises.Any()) return;

            var exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        Name = "Back Squat",
                        Description = "A squat with the barbell on your back.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.FullBody,
                    },
                    new Exercise
                    {
                        Name = "Power Clean",
                        Description = "A full barbell power clean from the ground.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.FullBody,
                    },
                    new Exercise
                    {
                        Name = "Bench Press",
                        Description = "A barbell bench press.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Chest,
                    },
                    new Exercise
                    {
                        Name = "Push Up",
                        Description = "A full push up with your chest touching the ground and your arms extended.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Chest,
                    },
                    new Exercise
                    {
                        Name = "Front Lunge",
                        Description = "A forward lunge with the barbell.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.FullBody,
                    },
                    new Exercise
                    {
                        Name = "Calf Extensions",
                        Description = "Extending your calves, with your toes on a raised surface.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Calves,
                    },
                    new Exercise
                    {
                        Name = "Tricep Extensions",
                        Description = "Using a barbell, dumbells, or machine to extend your triceps without moving your elbows.",
                        ExerciseType = ExerciseType.UpperBodyIsolation,
                        MuscleGroup = MuscleGroup.Triceps,
                    },
                    new Exercise
                    {
                        Name = "Deadlift",
                        Description = "A barbell lift from the ground to hip level.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.Back,
                    },
                    new Exercise
                    {
                        Name = "Shoulder Press",
                        Description = "A barbell or dumbbell press overhead.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Shoulders,
                    },
                    new Exercise
                    {
                        Name = "Bicep Curl",
                        Description = "A dumbbell or barbell curl targeting the biceps.",
                        ExerciseType = ExerciseType.UpperBodyIsolation,
                        MuscleGroup = MuscleGroup.Biceps,
                    },
                    new Exercise
                    {
                        Name = "Leg Press",
                        Description = "A machine-based press that targets the legs.",
                        ExerciseType = ExerciseType.LowerBody,
                        MuscleGroup = MuscleGroup.Thighs,
                    },
                    new Exercise
                    {
                        Name = "Lat Pulldown",
                        Description = "A machine-based pulldown exercise targeting the lats.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Back,
                    },
                    new Exercise
                    {
                        Name = "Leg Curl",
                        Description = "A machine exercise focusing on curling the legs towards the glutes.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Hamstrings,
                    },
                    new Exercise
                    {
                        Name = "Chest Fly",
                        Description = "A dumbbell exercise on a bench targeting the chest muscles.",
                        ExerciseType = ExerciseType.UpperBodyIsolation,
                        MuscleGroup = MuscleGroup.Chest,
                    },
                    new Exercise
                    {
                        Name = "Russian Twist",
                        Description = "A core exercise involving twisting the torso with or without weight.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Abs,
                    },
                    new Exercise
                    {
                        Name = "Leg Raise",
                        Description = "An exercise that involves raising the legs while lying down to target the lower abs.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Abs,
                    },
                    new Exercise
                    {
                        Name = "Hip Thrust",
                        Description = "An exercise targeting the glutes by thrusting the hips upward with a barbell.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Glutes,
                    }
                };


            await context.Exercises.AddRangeAsync(exercises);
            await context.SaveChangesAsync();
        }

        public static async Task ReseedData(DataContext context)
        {
            if (context.Exercises.Any()) return;

            var exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        Name = "Back Squat",
                        Description = "A squat with the barbell on your back.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.FullBody,
                    },
                    new Exercise
                    {
                        Name = "Power Clean",
                        Description = "A full barbell power clean from the ground.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.FullBody,
                    },
                    new Exercise
                    {
                        Name = "Bench Press",
                        Description = "A barbell bench press.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Chest,
                    },
                    new Exercise
                    {
                        Name = "Push Up",
                        Description = "A full push up with your chest touching the ground and your arms extended.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Chest,
                    },
                    new Exercise
                    {
                        Name = "Front Lunge",
                        Description = "A forward lunge with the barbell.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.FullBody,
                    },
                    new Exercise
                    {
                        Name = "Calf Extensions",
                        Description = "Extending your calves, with your toes on a raised surface.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Calves,
                    },
                    new Exercise
                    {
                        Name = "Tricep Extensions",
                        Description = "Using a barbell, dumbells, or machine to extend your triceps without moving your elbows.",
                        ExerciseType = ExerciseType.UpperBodyIsolation,
                        MuscleGroup = MuscleGroup.Triceps,
                    },
                    new Exercise
                    {
                        Name = "Deadlift",
                        Description = "A barbell lift from the ground to hip level.",
                        ExerciseType = ExerciseType.FullBody,
                        MuscleGroup = MuscleGroup.Back,
                    },
                    new Exercise
                    {
                        Name = "Shoulder Press",
                        Description = "A barbell or dumbbell press overhead.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Shoulders,
                    },
                    new Exercise
                    {
                        Name = "Bicep Curl",
                        Description = "A dumbbell or barbell curl targeting the biceps.",
                        ExerciseType = ExerciseType.UpperBodyIsolation,
                        MuscleGroup = MuscleGroup.Biceps,
                    },
                    new Exercise
                    {
                        Name = "Leg Press",
                        Description = "A machine-based press that targets the legs.",
                        ExerciseType = ExerciseType.LowerBody,
                        MuscleGroup = MuscleGroup.Thighs,
                    },
                    new Exercise
                    {
                        Name = "Lat Pulldown",
                        Description = "A machine-based pulldown exercise targeting the lats.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Back,
                    },
                    new Exercise
                    {
                        Name = "Leg Curl",
                        Description = "A machine exercise focusing on curling the legs towards the glutes.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Hamstrings,
                    },
                    new Exercise
                    {
                        Name = "Chest Fly",
                        Description = "A dumbbell exercise on a bench targeting the chest muscles.",
                        ExerciseType = ExerciseType.UpperBodyIsolation,
                        MuscleGroup = MuscleGroup.Chest,
                    },
                    new Exercise
                    {
                        Name = "Russian Twist",
                        Description = "A core exercise involving twisting the torso with or without weight.",
                        ExerciseType = ExerciseType.UpperBody,
                        MuscleGroup = MuscleGroup.Abs,
                    },
                    new Exercise
                    {
                        Name = "Leg Raise",
                        Description = "An exercise that involves raising the legs while lying down to target the lower abs.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Abs,
                    },
                    new Exercise
                    {
                        Name = "Hip Thrust",
                        Description = "An exercise targeting the glutes by thrusting the hips upward with a barbell.",
                        ExerciseType = ExerciseType.LowerBodyIsolation,
                        MuscleGroup = MuscleGroup.Glutes,
                    }
                };


            await context.Exercises.AddRangeAsync(exercises);
            await context.SaveChangesAsync();
        }
    }
}