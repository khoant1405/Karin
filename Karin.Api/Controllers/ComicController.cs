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
        public IActionResult GetComic()
        {
            var result = BaseResponse<ICollection<ResGetComicDto>>.CreateSuccess(_comicService.GetData(), _localizer["SuccessMessage"]);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateComic(ReqCreateComicDto model)
        {
            var result = BaseResponse<ICollection<ResGetComicDto>>.CreateSuccess(_comicService.GetData(), _localizer["SuccessMessage"]);
            return Ok(result);
        }
    }
}