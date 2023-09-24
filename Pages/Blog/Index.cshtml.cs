using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor8.Models;

namespace razor8.Pages_Blog
{
    public class IndexModel : PageModel
    {
        private readonly razor8.Models.MyBlogContext _context;

        public IndexModel(razor8.Models.MyBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            var qr = from a in _context.Articles select a;
            if(string.IsNullOrEmpty(SearchString))
            {
                Article = await qr.ToListAsync();
            }
            else
            {
                Article = qr.Where(a => a.Title.Contains(SearchString)).ToList();
            }
            
        }
    }
}
