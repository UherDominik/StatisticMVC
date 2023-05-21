using Microsoft.AspNetCore.Mvc;
using StatisticMVC.Models;

namespace StatisticMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StatisticCalculator statisticCalculator = new StatisticCalculator();
            return View(statisticCalculator);
        }
        [HttpPost]
        public IActionResult Index(StatisticCalculator statisticCalculator)
        {
            if( ModelState.IsValid )
            {
                statisticCalculator.ConvertList(statisticCalculator.InputText);
                statisticCalculator.GetMaxNumber();
                statisticCalculator.GetMinNumber();
                statisticCalculator.GetAvgNumber();
                statisticCalculator.GetSortedNumbers();
            }
            return View(statisticCalculator);
        }
    }
}
