using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

using SolarCalc.Pages;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Http;
using System.Collections.Specialized;


using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Eventing.Reader;




namespace SolarCalc.pages
{
    public class CalcModel : PageModel
    {
        private readonly ILogger<CalcModel> _logger;

        [BindProperty]
        public double eff { get; set; }

        [BindProperty]
        public int CityID { set; get; }

        [BindProperty]
        public double space { set; get; }

        [BindProperty]
        public double GHI1 { get; set; } = 330.6775906;
        [BindProperty]
        public double GHI2 { get; set; } = 166.982394;
        [BindProperty]
        public double GHI3 { get; set; } = 193.8975649;
        [BindProperty]
        public double GHI4 { get; set; } = 218.9044899;

        [BindProperty]
        public double cost1 { get; set; }

        [BindProperty]
        public double cost2 { get; set; }

        public double[] MyArray { get; set; } 

        

        public CalcModel(ILogger<CalcModel> logger)
        {
        }

        public void OnGet()
        {
            
        }

        private bool IsValidFinalResult(double result)
        {
            return result >= 0;
        }

        public void makeCalc()

        {
            double GHI;

            switch (CityID)
            {
                case 1:
                    GHI = GHI1;
                    break;
                case 2:
                    GHI = GHI2;
                    break;
                case 3:
                    GHI = GHI3;
                    break;
                default:
                    GHI = GHI4;
                    break;
            }



            eff = ((GHI * space) / (1000 * space)) * 100;

            cost1 = (int)(space * 0.625 * 600);

            cost2 = (int)(space * 0.625 * 150);
        }

        public IActionResult OnPost()
        {
            if (!IsValidFinalResult(eff))
            {
                return Page();
            }

            makeCalc();
            
            return Page();
        }
    }
}