using Microsoft.AspNetCore.Mvc;
using static WebAppLiftItt.Models.Exercise;

namespace WebAppLiftItt.Models
{
		public class WorkoutExercise
		{
			public int Id { get; set; }

			// Navigation properties for Workout and Exercise
			public int WorkoutId { get; set; }
			public Workout Workout { get; set; }

			public int ExerciseId { get; set; }
			public Exercise Exercise { get; set; }
			public ICollection<Sets> Sets { get; set; }
	}
}
