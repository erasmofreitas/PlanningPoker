using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.Application.Interfaces;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Services
{
   public class ApplicationServiceHistorias : IHistoriasApplication
    {
        private readonly IServiceHistorias _serviceHistorias;
        private readonly IMapperHistorias _mapperHistorias;

        public ApplicationServiceHistorias(IServiceHistorias serviceHistorias, IMapperHistorias mapperHistorias)
        {
            _serviceHistorias = serviceHistorias;
            _mapperHistorias = mapperHistorias;
        }
        public void Add(HistoriasDTO HistoriasDTO)
        {
            var objCarta = _mapperHistorias.MapperToEntity(HistoriasDTO);
            _serviceHistorias.Add(objCarta);
        }

        public void Dispose()
        {
            _serviceHistorias.Dispose();
        }

        public IEnumerable<HistoriasDTO> GetAll()
        {
            var objCarta = _serviceHistorias.GetAll();
            return _mapperHistorias.MapperListHistorias(objCarta);
        }

        public HistoriasDTO GetById(int id)
        {
            var objHistorias = _serviceHistorias.GetById(id);
            return _mapperHistorias.MapperToDTO(objHistorias);
        }

        public void Remove(HistoriasDTO HistoriasDTO)
        {
            var objHistorias = _mapperHistorias.MapperToEntity(HistoriasDTO);
            _serviceHistorias.Remove(objHistorias);
        }

        public void Update(HistoriasDTO HistoriasDTO)
        {
            var objCliente = _mapperHistorias.MapperToEntity(HistoriasDTO);
            _serviceHistorias.Update(objCliente);
        }

    }
}
