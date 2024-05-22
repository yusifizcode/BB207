using Eflyer.Areas.Admin.ViewModels;
using Eflyer.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eflyer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        //public async Task<IActionResult> CreateRoles()
        //{
        //    IdentityRole role1 = new IdentityRole("Admin");
        //    IdentityRole role2 = new IdentityRole("Member");
        //    await _roleManager.CreateAsync(role1);
        //    await _roleManager.CreateAsync(role2);

        //    return Ok("rollar yarandi!");
        //}

        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser admin = new()
        //    {
        //        FullName = "Admin Adminov",
        //        UserName = "SuperAdmin",
        //        Email = "admin@gmail.com"
        //    };

        //    await _userManager.CreateAsync(admin, "Admin123@");
        //    return Ok("admin yarandi");
        //}

        //public async Task<IActionResult> AddToRoleAdmin()
        //{
        //    var admin = await _userManager.FindByNameAsync("SuperAdmin");
        //    await _userManager.AddToRoleAsync(admin, "Admin");

        //    return Ok("rol elave olundu!");
        //}

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginVm adminLoginVm)
        {
            if (!ModelState.IsValid)
                return View();

            var admin = await _userManager.FindByNameAsync(adminLoginVm.UserName);
            if (admin == null)
            {
                ModelState.AddModelError("", "Username or password is not correct!");
                return View();
            }

            var check = await _userManager.CheckPasswordAsync(admin, adminLoginVm.Password);

            if (!check)
            {
                ModelState.AddModelError("", "Username or password is not correct!");
                return View();
            }

            await _signInManager.PasswordSignInAsync(admin, adminLoginVm.Password, false, false);
            return RedirectToAction(nameof(Index), "Dashboard");
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
