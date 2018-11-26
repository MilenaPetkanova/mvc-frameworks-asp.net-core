namespace ChuskaAsp.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Eventure.ViewModels.Users;
    using Eventure.Models;

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
            if (this.User.Identity.Name != null)
            {
                await signInManager.SignOutAsync();
            }

            var isUsernameExists = userManager.Users.FirstOrDefault(u => u.UserName == model.Username);
            if (isUsernameExists != null || model.Password != model.ConfirmPassword)
            {
                return RedirectToAction("Register", "Users", model);
            }
            //if (isUsernameExists != null && model.Password == model.ConfirmPassword)
            //{
            //    return RedirectToAction("Register", "Users", model);
            //}

            var user = new EventureUser()
            {
                UserName = model.Username,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName= model.LastName,
                UCN = model.UCN
            };

            await userManager.CreateAsync(user, model.Password);
            await userManager.AddToRoleAsync(user, "User");

            return RedirectToAction("Login", "Index");
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
            if (ModelState.IsValid)
            {
                EventureUser user = await userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, true, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    //if (result.Succeeded && User.IsInRole("Admin"))
                    //{
                    //    return RedirectToAction("IndexAdmin", "Home");
                    //}
                    //if (result.Succeeded && User.IsInRole("User"))
                    //{
                    //    return RedirectToAction("IndexUser", "Home");
                    //}
                }
            }

            return RedirectToAction("Login", "Users");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
