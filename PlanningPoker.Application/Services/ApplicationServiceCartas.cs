using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.Application.Interfaces;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Services
{
   public class ApplicationServiceCartas : ICartasApplication
    {
        private readonly IServiceCartas _serviceCartas;
        private readonly IMapperCartas _mapperCartas;

        public ApplicationServiceCartas(IServiceCartas serviceCartas, IMapperCartas mapperCartas)
        {
            _serviceCartas = serviceCartas;
            _mapperCartas = mapperCartas;
        }

        public void Add(CartasDTO cartasDTO)
        {
            var objCarta = _mapperCartas.MapperToEntity(cartasDTO);
            _serviceCartas.Add(objCarta);
        }

        public void Dispose()
        {
            _serviceCartas.Dispose();
        }

        public IEnumerable<CartasDTO> GetAll()
        {
            var objCarta = _serviceCartas.GetAll();
            return _mapperCartas.MapperListCartas(objCarta);
        }

        public CartasDTO GetById(int id)
        {
            var objCartas = _serviceCartas.GetById(id);
            return _mapperCartas.MapperToDTO(objCartas);
        }

        public void Remove(CartasDTO cartasDTO)
        {
            var objCartas = _mapperCartas.MapperToEntity(cartasDTO);
            _serviceCartas.Remove(objCartas);
        }

        public void Update(CartasDTO cartasDTO)
        {
            var objCliente = _mapperCartas.MapperToEntity(cartasDTO);
            _serviceCartas.Update(objCliente);
        }
    }
}
