using Karin.Application.DTOs.Comic;
using Karin.Application.Interfaces;
using Karin.Domain;
using Karin.Domain.Entities;

namespace Karin.Application.Services
{
    public class ComicService : IComicService
    {
        private readonly IRepository<Comic> _repository;

        public ComicService(IRepository<Comic> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ResGetComicDto>> GetDataAsync()
        {
            var result = (await _repository.GetAllAsync()).Select(x => new ResGetComicDto
            {
                Id = x.Id,
                Name = x.Name
            });
            return result;
        }

        public async Task<ResGetComicDto> CreateComic(ReqCreateComicDto model)
        {
            var comic = new Comic
            {
                Name = model.Name
            };

            await _repository.AddAsync(comic);

            return new ResGetComicDto
            {
                Id = comic.Id,
                Name = comic.Name
            };
        }
    }
}