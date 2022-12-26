using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sinema.MVCUI.Identity;
using Sinema.MVCUI.Models;

namespace Sinema.MVCUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<SinemaUser> userManager;
        private readonly SignInManager<SinemaUser> signInManager;
        private readonly RoleManager<SinemaUser> roleManager;

        public LoginController(UserManager<SinemaUser> userManager
                                , SignInManager<SinemaUser> signInManager
                                , RoleManager<SinemaUser> roleManager)
        {

            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {

            RegisterVM register = new RegisterVM();
            return View(register);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            SinemaUser user = new SinemaUser
            {
                TcNo = register.TcNo,
                Email = register.Email,
                UserName = register.UserName
            };

            var sonuc = await userManager.CreateAsync(user, register.Password);

            if (!sonuc.Succeeded)
            {
                return View(register);
            }

            // Mail gonderme işlemi burada yapilacak.
            //aliveli6270@gmail.com
            //password :aliveli1234567890

            await userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Logout()
        {
            return View();
        }
    }
}
