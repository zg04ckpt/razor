using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor8.Models;

namespace razor8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyBlogContext _blogContext;
        public IndexModel(ILogger<IndexModel> logger, MyBlogContext blogContext)
        {
            _blogContext = blogContext;
            _logger = logger;
        }

        public void OnGet()
        {
            var post = (from a in _blogContext.Articles
                       orderby a.Created descending
                       select a).ToList();

            ViewData["posts"] = post;
        }
    }
}