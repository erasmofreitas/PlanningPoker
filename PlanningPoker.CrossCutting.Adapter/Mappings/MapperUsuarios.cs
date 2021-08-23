using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Mappings
{
   public class MapperUsuarios : IMapperUsuarios
    {
        #region properties

        List<UsuariosDTO> UsuariosDTOs = new List<UsuariosDTO>();

        #endregion


        #region methods

        public Usuarios MapperToEntity(UsuariosDTO UsuariosDTO)
        {
            Usuarios Usuarios = new Usuarios
            {
                Id = UsuariosDTO.Id
                ,
                Nome = UsuariosDTO.Nome
            };

            return Usuarios;

        }


        public IEnumerable<UsuariosDTO> MapperListUsuarios(IEnumerable<Usuarios> Usuarios)
        {
            foreach (var item in Usuarios)
            {


                UsuariosDTO UsuariosDTO = new UsuariosDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                };



                UsuariosDTOs.Add(UsuariosDTO);

            }

            return UsuariosDTOs;
        }

        public UsuariosDTO MapperToDTO(Usuarios Usuarios)
        {

            UsuariosDTO UsuariosDTO = new UsuariosDTO
            {
                Id = Usuarios.Id
                ,
                Nome = Usuarios.Nome
            };

            return UsuariosDTO;

        }

        #endregion

    }

}
