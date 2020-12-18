using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _06.razor02.layout.Models
{
    public class CustomerInfo
    {
        [Required(ErrorMessage = "Phải có tên")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Chiều dài không chính xác")]
        [Display(Name = "TÊN KHÁCH")] // Label hiện thị
        [ModelBinder(BinderType = typeof(MyCheckNameBinding))]
        public string Customername { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "EMAIL")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Thiếu năm sinh")]
        [Display(Name = "NĂM SINH")]
        [Range(1970, 2000, ErrorMessage = "Khoảng năm sinh sai")]
       
        public int? YearOfBirth { set; get; }
    }
}
