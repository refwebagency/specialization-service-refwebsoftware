using System;
using System.Collections.Generic;
using System.Linq;
using SpecializationService.Models;
using Microsoft.EntityFrameworkCore;

namespace SpecializationService.Data
{
    public class SpecializationRepo : ISpecializationRepo
    {

        private readonly AppDbContext _context;

        public SpecializationRepo(AppDbContext context)
        {
            // On initialise le context 
            _context = context;
        }

        public void CreateSpecialization(Specialization Specialization)
        {
            if (Specialization == null)
            {
                throw new ArgumentNullException(nameof(Specialization));
            }

            _context.Add(Specialization);
            _context.SaveChanges();
        }

        public void DeleteSpecializationById(int id)
        {
            var Specialization = _context.Specialization.FirstOrDefault(Specialization => Specialization.Id == id);

            if (Specialization != null)
            {
                _context.Specialization.Remove(Specialization);
            }
        }

        public IEnumerable<Specialization> GetAllSpecialization()
        {
            return _context.Specialization.ToList();
        }

        public Specialization GetSpecializationById(int id)
        {
            return _context.Specialization.FirstOrDefault(Specialization => Specialization.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0 );
        }

        public void UpdateSpecializationById(int id)
        {
            var Specialization = _context.Specialization.FirstOrDefault(Specialization => Specialization.Id == id);

            _context.Entry(Specialization).State = EntityState.Modified;
        }
    }
}