using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAppLiftItt.Models
{
		public class Sets
		{
			public int Id { get; set; }

			[Required(ErrorMessage = "You must enter the amount of reps")]
			[Range(0, 1000, ErrorMessage = "You must enter a value between 0 and 1000")]
			public int Reps { get; set; }

			[Required(ErrorMessage = "You must enter the amount of weight")]
			[Range(0, 1000, ErrorMessage = "You must enter a value between 0 and 1000")]
			public int Weight { get; set; }
		}
}
