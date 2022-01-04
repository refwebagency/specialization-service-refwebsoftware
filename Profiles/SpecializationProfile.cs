using AutoMapper;
using SpecializationService.Dtos;
using SpecializationService.Models;

namespace SpecializationService.Profiles
{
    public class SpecializationProfile : Profile
    {
        public SpecializationProfile()
        {
            CreateMap<Specialization, ReadSpecializationDTO>();
            CreateMap<CreateSpecializationDTO, Specialization>();
            CreateMap<UpdateSpecializationDTO, Specialization>();
        }
    }
}