using Karin.Application.DTOs.Comic;

namespace Karin.Application.Interfaces
{
    public interface IComicService
    {
        Task<IEnumerable<ResGetComicDto>> GetDataAsync();

        Task<ResGetComicDto> CreateComic(ReqCreateComicDto model);
    }
}