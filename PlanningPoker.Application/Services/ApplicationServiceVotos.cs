using PlanningPoker.Application.DTO;
using PlanningPoker.Application.Interfaces;
using PlanningPoker.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Services
{
   public class ApplicationServiceVotos : IVotosApplication
    {
        private readonly IServiceVotos _serviceVotos;
        private readonly IMapperVotos _mapperVotos;

        public ApplicationServiceVotos(IServiceVotos serviceVotos, IMapperVotos mapperVotos)
        {
            _serviceVotos = serviceVotos;
            _mapperVotos = mapperVotos;
        }
        public void Add(VotosDTO VotosDTO)
        {
            var objCarta = _mapperVotos.MapperToEntity(VotosDTO);
            _serviceVotos.Add(objCarta);
        }

        public void Dispose()
        {
            _serviceVotos.Dispose();
        }

        public IEnumerable<VotosDTO> GetAll()
        {
            var objCarta = _serviceVotos.GetAll();
            return _mapperVotos.MapperListVotos(objCarta);
        }

        public VotosDTO GetById(int id)
        {
            var objVotos = _serviceVotos.GetById(id);
            return _mapperVotos.MapperToDTO(objVotos);
        }

        public void Remove(VotosDTO VotosDTO)
        {
            var objVotos = _mapperVotos.MapperToEntity(VotosDTO);
            _serviceVotos.Remove(objVotos);
        }

        public void Update(VotosDTO VotosDTO)
        {
            var objCliente = _mapperVotos.MapperToEntity(VotosDTO);
            _serviceVotos.Update(objCliente);
        }

    }
}
