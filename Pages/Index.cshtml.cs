using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPokus.Models;

namespace RazorPokus.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public CounterIM counter { get; set; } = new CounterIM();

        public void OnGet()
        {
            counter.Value = (counter.Value != 0) ? counter.Value: 0;
        }

        public void OnGetChange(int current, int amount)
        {
            counter.Value += amount + current;
        }

        public void OnPost()
        {
            counter.Value += counter.Amount;
        }
    }
}
