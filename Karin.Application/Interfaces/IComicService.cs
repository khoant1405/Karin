using Karin.Application.DTOs.Comic;

namespace Karin.Application.Interfaces
{
    public interface IComicService
    {
        ICollection<ResGetComicDto> GetData();
    }
}