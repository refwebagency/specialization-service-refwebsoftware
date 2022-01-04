using System;
using System.Collections.Generic;
using AutoMapper;
using SpecializationService.Data;
using SpecializationService.Dtos;
using SpecializationService.Models;
using Microsoft.AspNetCore.Mvc;

namespace SpecializationService.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SpecializationController : ControllerBase
    {
        private readonly ISpecializationRepo _repository;
        private readonly IMapper _mapper;

        public SpecializationController(IMapper mapper, ISpecializationRepo repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadSpecializationDTO>> GetAllSpecialization()
        {
            var specializationItems = _repository.GetAllSpecialization();

            return Ok(_mapper.Map<IEnumerable<ReadSpecializationDTO>>(specializationItems));
        }

        [HttpGet("{id}", Name = "GetSpecializationById")]
        public ActionResult<ReadSpecializationDTO> GetSpecializationById(int id)
        {
            var specializationItem = _repository.GetSpecializationById(id);

            if (specializationItem == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ReadSpecializationDTO>(specializationItem));
        }

        [HttpPost]
        public ActionResult<CreateSpecializationDTO> CreateSpecialization(CreateSpecializationDTO specializationDTO)
        {
            var specializationModel = _mapper.Map<Specialization>(specializationDTO);

            _repository.CreateSpecialization(specializationModel);
            _repository.SaveChanges();

            var readSpecialization = _mapper.Map<ReadSpecializationDTO>(specializationModel);

            return CreatedAtRoute(nameof(GetSpecializationById), new {id = readSpecialization.Id }, readSpecialization);
        }

        [HttpPut("{id}", Name = "UpdateSpecializationById")]
        public ActionResult<UpdateSpecializationDTO> UpdateSpecializationById(int id, UpdateSpecializationDTO specializationDTO)
        {
            var SpecializationItem = _repository.GetSpecializationById(id);

            _mapper.Map(specializationDTO, SpecializationItem);

            if (SpecializationItem == null)
            {
                return NotFound();
            }

            _repository.UpdateSpecializationById(id);
            _repository.SaveChanges();

            return CreatedAtRoute(nameof(GetSpecializationById), new {id = specializationDTO.Id }, specializationDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSpecializationById(int id)
        {
            var SpecializationItem = _repository.GetSpecializationById(id);

            if (SpecializationItem == null)
            {
                return NotFound();
            }

            _repository.DeleteSpecializationById(SpecializationItem.Id);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}