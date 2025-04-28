using Karin.Application.DTOs.Sample;
using Karin.Shared.Localization;
using Karin.Shared.Result;
using Microsoft.AspNetCore.Mvc;

namespace Karin.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing"
        };

        private readonly ILocalizationService _localizationService;
        private readonly ILogger<SampleController> _logger;

        public SampleController(ILocalizationService localizationService, ILogger<SampleController> logger)
        {
            _localizationService = localizationService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetSample()
        {
            var result = BaseResponse<List<ResGetSampleDto>>.CreateSuccess([
                .. Enumerable.Range(1, 2).Select(index => new ResGetSampleDto
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
            ], _localizationService.Get("SuccessMessage"));

            return Ok(result);
        }

        [HttpPost]
        public IActionResult PostSample(ReqPostSampleDto model)
        {
            var result = BaseResponse<List<ResGetSampleDto>>.CreateSuccess([
                .. Enumerable.Range(1, 2).Select(index => new ResGetSampleDto
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
            ], _localizationService.Get("SuccessMessage"));

            return Ok(result);
        }
    }
}