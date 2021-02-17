using System.Linq;

namespace WeatherApp
{
    public static class SeedData
    {
        public static void SeedWeatherSummaryData(AppDbContext _appDbContext)
        {
            var summariesExisted = _appDbContext.WeatherSummaries.ToArray();

            string[] summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            _appDbContext.WeatherSummaries
                .AddRange(
                    summaries
                    .Where(t => !summariesExisted.Any(x => x.Summary.Equals(t)))
                    .Select(t => new Models.WeatherSummary()
                    {
                        Summary = t
                    })
                .ToArray());
        }
    }
}
