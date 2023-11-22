using Microsoft.AspNetCore.Mvc;
using WeatherAssignment.Models;

namespace WeatherAssignment.ViewComponents
{

    [ViewComponent]
    public class CityViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather city)
        {
            return View(city);
        }
    }
}
