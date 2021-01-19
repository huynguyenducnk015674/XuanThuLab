using Microsoft.AspNetCore.Mvc;

namespace _09.Album.Pages.Shared.Components.MessagePage
{
    /// <summary>
    /// Tên lớp khai báo làm ViewComponent phải thoả các điều kiện
    /// 1. Tên lớp phải có hậu tố ViewComponent ( MessagePaneViewComponent) hoặt phải có thuộc tính [ViewComponent].
    /// 2. Phải triển khai phương thức InVoke trả về IViewComponentResult hoặt triển khai InvokeAsync trả v62 Task<IViewComponentResult>
    /// 3. Phải có một trang razor. Trang này không có @Page. tên mặc định là default.cshtml. Nếu khác thì phải tường minh
    [ViewComponent]
    public class MessagePage : ViewComponent
    {
        public const string COMPONENTNAME = "MessagePage";
        // Dữ liệu nội dung trang thông báo
        public class Message
        {
            public string title { set; get; } = "Thông báo";     // Tiêu đề của Box hiện thị
            public string htmlcontent { set; get; } = "";         // Nội dung HTML hiện thị
            public string urlredirect { set; get; } = "/";        // Url chuyển hướng đến
            public int secondwait { set; get; } = 3;              // Sau secondwait giây thì chuyển
        }
        public MessagePage() { }
        public IViewComponentResult Invoke(Message message)
        {
            // Thiết lập Header của HTTP Respone - chuyển hướng về trang đích
            this.HttpContext.Response.Headers.Add("REFRESH", $"{message.secondwait};URL={message.urlredirect}");

            return View(message); // Nếu khác Default.cshtml thì trả về View("abc", product) cho abc.cshtml
        }
    }
}
