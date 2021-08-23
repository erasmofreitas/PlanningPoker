using PlanningPoker.Application.DTO;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Interfaces
{
   public interface IMapperVotos
    {
        Votos MapperToEntity(VotosDTO votosDTO);


        IEnumerable<VotosDTO> MapperListCartas(IEnumerable<Votos> votos);
        VotosDTO MapperToDTO(Votos votos);
    }
}
