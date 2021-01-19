using _06.razor02.layout.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace _06.razor02.layout.Pages
{
    public class UploadOneFileModel : PageModel
    {
        readonly IWebHostEnvironment envir;
        [Required(ErrorMessage = "Hãy chọn một file")]
        [DataType(DataType.Upload)]
        //[FileExtensions(Extensions = "png,jpg,jpeg,gif")]
        [Models.FileExtensionsAttribute(new string[] { "png,jpg,jpeg,gif" },
            errorMessage: "Trong danh sách có tồn tại file không đúng định dạng")]
        [MaxFileSizeAttribute(5)]
        [Display(Name = "Chọn file để upload")]
        [BindProperty]
        public IFormFile FileUploads { get; set; }
        public UploadOneFileModel(IWebHostEnvironment envir)
        {
            this.envir = envir;
        }
        public void OnGet()
        {
        }
        public async Task OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //var file = Path.Combine(envir.ContentRootPath, "Uploads", FileUploads.FileName);
                //using (var stream = new FileStream(file, FileMode.Create))
                //{
                //    await FileUploads.CopyToAsync(stream);
                //}
            }

        }
    }
}
