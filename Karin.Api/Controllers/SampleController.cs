using Karin.Application.DTOs.Sample;
using Karin.Application.Interfaces;
using Karin.Resources;
using Karin.Shared.Result;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Karin.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        private readonly ILogger<SampleController> _logger;
        private readonly ISampleService _sampleService;

        public SampleController(IStringLocalizer<SharedResource> localizer, ILogger<SampleController> logger, ISampleService sampleService)
        {
            _localizer = localizer;
            _logger = logger;
            _sampleService = sampleService;
        }

        [HttpGet]
        public IActionResult GetSample()
        {
            var result = BaseResponse<ICollection<ResGetSampleDto>>.CreateSuccess(_sampleService.GetData(), _localizer["SuccessMessage"]);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult PostSample(ReqPostSampleDto model)
        {
            var result = BaseResponse<ICollection<ResGetSampleDto>>.CreateSuccess(_sampleService.GetData(), _localizer["SuccessMessage"]);
            return Ok(result);
        }
    }
}