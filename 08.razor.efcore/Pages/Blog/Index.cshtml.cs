using _08.razor.efcore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08.razor.efcore.Pages_Blog
{
    public class IndexModel : PageModel
    {
        private readonly _08.razor.efcore.Context.ArticleContext _context;

        public IndexModel(_08.razor.efcore.Context.ArticleContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IList<Article> Article { get; set; }

        public async Task OnGetAsync()
        {
            var articles = from article in _context.Article select article;
            if (!String.IsNullOrEmpty(SearchString))
            {
                articles = articles.Where(a => a.Title.Contains(SearchString));
            }

            Article = await articles.ToListAsync();
        }
    }
}
