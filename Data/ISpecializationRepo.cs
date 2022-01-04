using System.Collections.Generic;
using SpecializationService.Models;

namespace SpecializationService.Data
{
    public interface ISpecializationRepo
    {
        bool SaveChanges();

        void CreateSpecialization(Specialization Specialization);

        IEnumerable<Specialization> GetAllSpecialization();

        Specialization GetSpecializationById(int id);

        void UpdateSpecializationById(int id);

        void DeleteSpecializationById(int id);
    }
}