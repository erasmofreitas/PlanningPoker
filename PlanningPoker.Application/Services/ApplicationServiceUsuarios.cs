using PlanningPoker.Application.DTO;
using PlanningPoker.Application.Interfaces;
using PlanningPoker.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Services
{
    public class ApplicationServiceUsuarios : IUsuariosApplication
    {
        private readonly IServiceUsuarios _serviceUsuarios;
        private readonly IMapperUsuarios _mapperUsuarios;

        public ApplicationServiceUsuarios(IServiceUsuarios serviceUsuarios, IMapperUsuarios mapperUsuarios)
        {
            _serviceUsuarios = serviceUsuarios;
            _mapperUsuarios = mapperUsuarios;
        }
                public void Add(UsuariosDTO UsuariosDTO)
        {
            var objCarta = _mapperUsuarios.MapperToEntity(UsuariosDTO);
            _serviceUsuarios.Add(objCarta);
        }

        public void Dispose()
        {
            _serviceUsuarios.Dispose();
        }

        public IEnumerable<UsuariosDTO> GetAll()
        {
            var objCarta = _serviceUsuarios.GetAll();
            return _mapperUsuarios.MapperListUsuarios(objCarta);
        }

        public UsuariosDTO GetById(int id)
        {
            var objUsuarios = _serviceUsuarios.GetById(id);
            return _mapperUsuarios.MapperToDTO(objUsuarios);
        }

        public void Remove(UsuariosDTO UsuariosDTO)
        {
            var objUsuarios = _mapperUsuarios.MapperToEntity(UsuariosDTO);
            _serviceUsuarios.Remove(objUsuarios);
        }

        public void Update(UsuariosDTO UsuariosDTO)
        {
            var objCliente = _mapperUsuarios.MapperToEntity(UsuariosDTO);
            _serviceUsuarios.Update(objCliente);
        }

    }
}
