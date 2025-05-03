using Karin.Application.DTOs.Comic;
using Karin.Application.Interfaces;
using Karin.Resources;
using Karin.Shared.Result;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Karin.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComicController : ControllerBase
    {
        private readonly IComicService _comicService;
        private readonly IStringLocalizer<SharedResource> _localizer;
        private readonly ILogger<ComicController> _logger;

        public ComicController(IStringLocalizer<SharedResource> localizer, ILogger<ComicController> logger, IComicService comicService)
        {
            _localizer = localizer;
            _logger = logger;
            _comicService = comicService;
        }

        [HttpGet]
        public async Task<IActionResult> GetComicAsync()
        {
            var data = await _comicService.GetDataAsync();
            var result = BaseResponse<IEnumerable<ResGetComicDto>>.CreateSuccess(data, _localizer["SuccessMessage"]);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComicAsync(ReqCreateComicDto request)
        {
            var comic = await _comicService.CreateComic(request);
            var result = BaseResponse<ResGetComicDto>.CreateSuccess(comic, _localizer["SuccessMessage"]);
            return Ok(result);
        }
    }
}