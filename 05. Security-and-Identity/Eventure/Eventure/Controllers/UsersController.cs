namespace ChuskaAsp.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Eventure.ViewModels.Users;
    using Eventure.Models;
    using Eventure.Helpers;

    [Authorize]
    public class UsersController : Controller
    {
        private UserManager<EventureUser> userManager;
        private SignInManager<EventureUser> signInManager;

        public UsersController(UserManager<EventureUser> userMgr, SignInManager<EventureUser> signinMgr)
        {
            this.userManager = userMgr;
            this.signInManager = signinMgr;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var isUsernameExists = userManager.Users.FirstOrDefault(u => u.UserName == model.UserName);
            if (isUsernameExists != null)
            {
                return this.View(model);
            }

            var user = new EventureUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UCN = model.UCN
            };

            var result = this.signInManager.UserManager.CreateAsync(user, model.Password).Result;
            var roleResult = this.signInManager.UserManager.AddToRoleAsync(user, Constants.ROLE_USER).Result;

            if (!result.Succeeded || !roleResult.Succeeded)
            {
                return this.View();
            }

            // With almost the same result:
            //await userManager.CreateAsync(user, model.Password);
            //await userManager.AddToRoleAsync(user, Constants.ROLE_USER);

            return RedirectToAction("Login", "Users");
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return this.View(model);
            }

            await signInManager.SignOutAsync();

            var result = await signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (!result.Succeeded)
            {
                return this.View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
