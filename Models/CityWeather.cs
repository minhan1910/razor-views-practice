namespace WeatherAssignment.Models
{
    public class CityWeather
    {
        public string CityUniqueCode {get; set;}
        public  string CityName {get; set;}
        public  DateTime DateAndTime {get; set;}
        public int TemperatureFahrenheit { get; set; }
    }

    public class WrapperCityWeather
    {
        public string? BackgrounColorBox { get; set; }
        public CityWeather? CityWeather { get; set; }
    }

    public static class CityWeatherFactory
    {
        public static List<CityWeather> GetCityWeathers()
        {
            return new List<CityWeather> { 
                new CityWeather() {CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
                new CityWeather() {CityUniqueCode = "NYC", CityName = "London", DateAndTime =Convert.ToDateTime( "2030-01-01 3:00"),  TemperatureFahrenheit = 60},
                new CityWeather() {CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82 },
            };
        }
    }
}
