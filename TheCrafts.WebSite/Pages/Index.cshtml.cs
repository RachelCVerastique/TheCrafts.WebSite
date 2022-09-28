using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheCrafts.WebSite.Models;
using TheCrafts.WebSite.Services;

namespace TheCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}