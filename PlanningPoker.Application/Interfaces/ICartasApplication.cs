using PlanningPoker.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Interfaces
{
   public interface ICartasApplication
    {
        void Add(CartasDTO cartasDTO);
        CartasDTO GetById(int id);
        IEnumerable<CartasDTO> GetAll();
        void Update(CartasDTO cartasDTO);
        void Remove(CartasDTO cartasDTO);
        void Dispose();
    }
}
