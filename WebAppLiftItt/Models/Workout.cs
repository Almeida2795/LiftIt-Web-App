using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppLiftItt.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must give a name to the workout")]
        [StringLength(100, ErrorMessage = "The Workout name cannot exceed 100 characters")]
        public string? Name { get; set; }

        // If a workout can have multiple exercises, use a collection instead of a single ExerciseId
        public ICollection<WorkoutExercise> WorkoutExercise { get; set; }
    }
}