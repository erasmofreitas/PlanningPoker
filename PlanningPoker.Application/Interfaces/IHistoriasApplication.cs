using PlanningPoker.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Interfaces
{
   public interface IHistoriasApplication
    {
        void Add(HistoriasDTO historiasDTO);
        HistoriasDTO GetById(int id);
        IEnumerable<HistoriasDTO> GetAll();
        void Update(HistoriasDTO historiasDTO);
        void Remove(HistoriasDTO historiasDTO);
        void Dispose();
    }
}
