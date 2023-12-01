using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppLiftItt.Data;
using WebAppLiftItt.Models;

namespace WebAppLiftItt.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly AppDbContext db;

        // Constructor to inject AppDbContext via Dependency Injection
        public WorkoutController(AppDbContext db)
        {
            this.db = db;
        }

        // Action method for displaying the NewWorkout view
        public IActionResult NewWorkout()
        {
			UpdateExList();
            return View();
        }

		public IActionResult UpdateExList()
		{
			// Retrieves a list of exercises from the database
			var exercises = db.Exercise.ToList();

			// Populates the dropdown selection with the available exercises
			ViewBag.ExerciseNames = new SelectList(exercises, "Id", "Name");
			return View();

		}

		[HttpPost]
		public IActionResult CreateExercise(Exercise exercise)
		{
			// Adds the received exercise object to the database
			db.Exercise.Add(exercise);
			// Saves changes to the database
			db.SaveChanges();

			// Redirects to the NewWorkout action method after adding the exercise
			return RedirectToAction("NewWorkout");
		}

		[HttpPost]
		public IActionResult DeleteExercise(int ExerciseID)
		{
			// Finds the exercise with the specified ExerciseID in the database
			Exercise exercise = db.Exercise.Where(e => e.Id == ExerciseID).FirstOrDefault();

			// Removes the found exercise from the database
			db.Exercise.Remove(exercise);

			// Saves changes to the database
			db.SaveChanges();

			// Retrieves a list of exercises from the database
			var exercises = db.Exercise.ToList();

			// Populates the dropdown selection with the available exercises
			ViewBag.ExerciseNames = new SelectList(exercises, "Id", "Name");

			// Redirects to the NewWorkout action method after deleting the exercise
			return RedirectToAction("NewWorkout");
		}

	}
}
