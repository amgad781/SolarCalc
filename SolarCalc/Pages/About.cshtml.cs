using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SolarCalc.Pages
{
    public class aboutModel : PageModel
    {
        private readonly ILogger<aboutModel> _logger;

        public aboutModel(ILogger<aboutModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
