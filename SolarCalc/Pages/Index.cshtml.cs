using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SolarCalc.Pages
{
    public class HomaePageModel : PageModel
    {
        private readonly ILogger<HomaePageModel> _logger;

        public HomaePageModel(ILogger<HomaePageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
