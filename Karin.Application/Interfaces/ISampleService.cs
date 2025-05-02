using Karin.Application.DTOs.Sample;

namespace Karin.Application.Interfaces
{
    public interface ISampleService
    {
        ICollection<ResGetSampleDto> GetData();
    }
}