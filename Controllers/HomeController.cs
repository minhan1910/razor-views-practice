using Microsoft.AspNetCore.Mvc;
using WeatherAssignment.Models;

namespace WeatherAssignment.Controllers
{
    public class HomeController : Controller
    {
        private static List<CityWeather> _cityWeather = CityWeatherFactory.GetCityWeathers();

        [Route("/")]
        public IActionResult Index()
        {
            return View(_cityWeather);
        }

        [Route("weather/{cityCode}")]
        public IActionResult Details(string cityCode)
        {
            if (!_cityWeather.Any(c => c.CityUniqueCode == cityCode))
            {
                return View("PageNotFound");
            }

            return View(_cityWeather.Where(c => c.CityUniqueCode == cityCode).FirstOrDefault());
        }
    }
}
