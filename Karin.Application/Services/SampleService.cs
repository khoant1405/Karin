using Karin.Application.DTOs.Sample;
using Karin.Application.Interfaces;

namespace Karin.Application.Services
{
    public class SampleService : ISampleService
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing"
        ];

        public ICollection<ResGetSampleDto> GetData()
        {
            var result = Enumerable.Range(1, 2).Select(index => new ResGetSampleDto
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList();
            return result;
        }
    }
}