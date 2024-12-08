using PrimeiraApi_WeatherForecast;
namespace PrimeiraApi_DbContext
{
    public class DbContext
    {
        private static List<WeatherForecast> database = new List<WeatherForecast>();

        public static List<WeatherForecast> DataBase{
            get {
                return database;
            }
        }
    }
}
