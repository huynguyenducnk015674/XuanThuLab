using System;
using System.ComponentModel.DataAnnotations;

namespace _08.razor.efcore.Model
{
    public class Article
    {

        public int ID { get; set; }
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Display(Name = "Ngày phát hành")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Nội dung")]
        public string Content { set; get; }
    }
}
