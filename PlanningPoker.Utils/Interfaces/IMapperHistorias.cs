using PlanningPoker.Application.DTO;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Interfaces
{
   public interface IMapperHistorias
    {
        Historias MapperToEntity(HistoriasDTO historiasDTO);


        IEnumerable<HistoriasDTO> MapperListHistorias(IEnumerable<Historias> historias);
        HistoriasDTO MapperToDTO(Historias historias);

    }
}
