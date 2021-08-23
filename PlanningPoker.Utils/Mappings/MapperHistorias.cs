using PlanningPoker.Application.DTO;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Mappings
{
   public class MapperHistorias : IMapperHistorias
    {
        #region properties

        List<HistoriasDTO> HistoriasDTOs = new List<HistoriasDTO>();

        #endregion


        #region methods

        public Historias MapperToEntity(HistoriasDTO HistoriasDTO)
        {
            Historias Historias = new Historias
            {
                Id = HistoriasDTO.Id
                ,
                Descricao = HistoriasDTO.Descricao
            };

            return Historias;

        }


        public IEnumerable<HistoriasDTO> MapperListHistorias(IEnumerable<Historias> Historias)
        {
            foreach (var item in Historias)
            {


                HistoriasDTO HistoriasDTO = new HistoriasDTO
                {
                    Id = item.Id
                   ,
                    Descricao = item.Descricao
                };



                HistoriasDTOs.Add(HistoriasDTO);

            }

            return HistoriasDTOs;
        }

        public HistoriasDTO MapperToDTO(Historias Historias)
        {

            HistoriasDTO HistoriasDTO = new HistoriasDTO
            {
                Id = Historias.Id
                ,
                Descricao = Historias.Descricao
            };

            return HistoriasDTO;

        }

        #endregion

    }
}