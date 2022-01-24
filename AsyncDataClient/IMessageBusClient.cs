using SpecializationService.Dtos;

namespace SpecializationService.AsyncDataClient
{
    public interface IMessageBusClient
    {
        void UpdatedSpecialization(UpdateSpecializationAsyncDTO updateSpecializationAsyncDTO);
    }
}