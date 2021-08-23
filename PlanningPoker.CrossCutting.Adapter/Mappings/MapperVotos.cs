using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Mappings
{
   public class MapperVotos : IMapperVotos
    {
        #region properties

        List<VotosDTO> VotosDTOs = new List<VotosDTO>();

        #endregion


        #region methods

        public Votos MapperToEntity(VotosDTO VotosDTO)
        {
            Votos Votos = new Votos
            {
                Id = VotosDTO.Id
                ,
                UsuarioId = VotosDTO.UsuarioId,
                CartaId = VotosDTO.CartaId,
                HistoriaId = VotosDTO.HistoriaId
            };

            return Votos;

        }


        public IEnumerable<VotosDTO> MapperListVotos(IEnumerable<Votos> Votos)
        {
            foreach (var item in Votos)
            {


                VotosDTO VotosDTO = new VotosDTO
                {
                    Id = item.Id
                   ,
                    UsuarioId = item.UsuarioId,
                    CartaId = item.CartaId,
                    HistoriaId = item.HistoriaId
                };



                VotosDTOs.Add(VotosDTO);

            }

            return VotosDTOs;
        }

        public VotosDTO MapperToDTO(Votos Votos)
        {

            VotosDTO VotosDTO = new VotosDTO
            {
                Id = Votos.Id
                ,
                UsuarioId = Votos.UsuarioId,
                CartaId = Votos.CartaId,
                HistoriaId = Votos.HistoriaId
            };

            return VotosDTO;

        }

        #endregion

    }

}
