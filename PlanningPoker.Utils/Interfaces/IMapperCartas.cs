using PlanningPoker.Application.DTO;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Interfaces
{
   public interface IMapperCartas
    {
        Cartas MapperToEntity(CartasDTO cartasDTO);


        IEnumerable<CartasDTO> MapperListCartas(IEnumerable<Cartas> cartas);
        CartasDTO MapperToDTO(Cartas cartas);
    }
}
