using Karin.Application.DTOs.Comic;
using Karin.Application.Interfaces;

namespace Karin.Application.Services
{
    public class ComicService : IComicService
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing"
        ];

        public ICollection<ResGetComicDto> GetData()
        {
            var result = Enumerable.Range(1, 2).Select(index => new ResGetComicDto
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList();
            return result;
        }
    }
}