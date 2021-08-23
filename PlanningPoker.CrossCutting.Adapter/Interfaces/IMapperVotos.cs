using PlanningPoker.Application.DTO.DTO;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Interfaces
{
   public interface IMapperVotos
    {
        Votos MapperToEntity(VotosDTO votosDTO);


        IEnumerable<VotosDTO> MapperListVotos(IEnumerable<Votos> votos);
        VotosDTO MapperToDTO(Votos votos);
    }
}
