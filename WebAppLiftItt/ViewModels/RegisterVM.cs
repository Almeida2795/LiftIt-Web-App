using System.ComponentModel.DataAnnotations;

namespace WebAppLiftItt.ViewModels
{
	public class RegisterVM
	{
		[Required]
		[DataType(DataType.Text)]
		public string? Username { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string? Password { get; set; }

		[Compare("Password", ErrorMessage = "Password don't match")]
		public string? PasswordConfirmation { get; set; }
	}
}
