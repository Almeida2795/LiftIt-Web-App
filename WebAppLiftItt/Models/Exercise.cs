using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAppLiftItt.Models
{
		public class Exercise
		{
			public int Id { get; set; }

			[Required(ErrorMessage = "The exercise name is required!")]
			[StringLength(100, ErrorMessage = "The exercise name cannot exceed 100 characters")]
			public string? Name { get; set; }

			[Required(ErrorMessage = "You must select the exercise type")]
			public string? Type { get; set; }
		}
}
