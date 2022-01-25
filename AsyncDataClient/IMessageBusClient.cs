using SpecializationService.Dtos;

namespace SpecializationService.AsyncDataClient
{
    public interface IMessageBusClient
    {
        void SendAnySpecialization(PublishedSpecializationAsyncDTO publishedSpecializationAsyncDTO);
    }
}