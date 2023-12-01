using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAppLiftItt.Models;
using WebAppLiftItt.ViewModels;

namespace WebAppLiftItt.Controllers
{
	public class AccountController : Controller
	{
		private readonly SignInManager<AppUser> signInManager;
		private readonly UserManager<AppUser> userManager;

		// Constructor to inject SignInManager and UserManager via Dependency Injection
		public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
		{
			this.signInManager = signInManager;
			this.userManager = userManager;
		}

		// Action method to display the Login view
		public IActionResult Login()
		{
			return View();
		}

		// Action method to display the Register view
		public IActionResult Register()
		{
			return View();
		}

		// POST action method to handle login form submission
		[HttpPost]
		public async Task<IActionResult> Login(LoginVM Model)
		{
			if (ModelState.IsValid)
			{
				// Attempt to sign in the user using SignInManager
				var result = await signInManager.PasswordSignInAsync(Model.Email!, Model.Password!, Model.RememberMe, false);

				if (result.Succeeded)
				{
					// Redirect to the home page if login is successful
					return RedirectToAction("Index", "Home");
				}

				// If login fails, add an error to ModelState
				ModelState.AddModelError("", "Invalid Login attempt");
				return View(Model);
			}

			// Return the view with the model if ModelState is not valid
			return View(Model);
		}

		// POST action method to handle registration form submission
		[HttpPost]
		public async Task<IActionResult> Register(RegisterVM model)
		{
			if (ModelState.IsValid)
			{
				// Create a new user using UserManager
				AppUser user = new()
				{
					UserName = model.Username,
					Email = model.Email,

				};

				// Attempt to create the user using UserManager
				var result = await userManager.CreateAsync(user, model.Password!);

				if (result.Succeeded)
				{
					// Sign in the user after successful registration
					await signInManager.SignInAsync(user, false);

					// Redirect to the home page
					return RedirectToAction("Index", "Home");
				}

				// If registration fails, add errors to ModelState
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
			}

			// Return the view if ModelState is not valid
			return View();
		}

		// Action method to handle user logout
		public async Task<IActionResult> Logout()
		{
			// Sign out the current user
			await signInManager.SignOutAsync();

			// Redirect to the home page after logout
			return RedirectToAction("Index", "Home");
		}
	}
}
