using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Interfaces
{
   public interface IMapperUsuarios
    {
        Usuarios MapperToEntity(UsuariosDTO usuariosDTO);


        IEnumerable<UsuariosDTO> MapperListUsuarios(IEnumerable<Usuarios> usuarios);
        UsuariosDTO MapperToDTO(Usuarios usuarios);
    }
}
