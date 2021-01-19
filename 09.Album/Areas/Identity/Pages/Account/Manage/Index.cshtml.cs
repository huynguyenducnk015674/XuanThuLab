using _09.Album.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace _09.Album.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public IndexModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [MaxLength(100)]
            [Display(Name = "Họ tên đầy đủ")]
            public string FullName { set; get; }

            [MaxLength(255)]
            [Display(Name = "Địa chỉ")]
            public string Address { set; get; }

            [DataType(DataType.Date)]
            [Display(Name = "Ngày sinh d/m/y")]
            public DateTime? Birthday { set; get; }
        }

        private async Task LoadAsync(AppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                FullName=user.FullName,
                Address=user.Address,
                Birthday=user.Birthday
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Không tải được tài khoản ID = '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Không có tài khoản ID: '{_userManager.GetUserId(User)}'.");
            }


            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Lỗi cập nhật số điện thoại.";
                    return RedirectToPage();
                }
            }
            // Cập nhật các trường bổ sung
            user.Address = Input.Address;
            user.Birthday = Input.Birthday;
            user.FullName = Input.FullName;
            await _userManager.UpdateAsync(user);
            // Đăng nhập lại để làm mới Cookie (không nhớ thông tin cũ)
            await _signInManager.RefreshSignInAsync(user);

            StatusMessage = "Hồ sơ của bạn đã cập nhật";
            return RedirectToPage();
        }
    }
}
