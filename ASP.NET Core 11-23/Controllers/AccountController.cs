using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Views.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_11_23.Controllers {
    public class AccountController : Controller {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl) {
            LoginVM login = new LoginVM();
            login.ReturnUrl = returnUrl;
            return View(login);
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login) {
            if (ModelState.IsValid) {
                AppUser appUser = await userManager.FindByNameAsync(login.UserName);
                if (appUser != null) {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, login.Password, login.Remember, false);
                    if (result.Succeeded) {
                        return Redirect(login.ReturnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(login.UserName), "Login Failed: Invalid UserName or password");
            }
            return View(login);
        }
        public async Task<IActionResult> Logout() {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied() {
            return View();
        }

    }
}
