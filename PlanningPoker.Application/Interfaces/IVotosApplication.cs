using PlanningPoker.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Interfaces
{
   public interface IVotosApplication
    {
        void Add(VotosDTO votosDTO);
        VotosDTO GetById(int id);
        IEnumerable<VotosDTO> GetAll();
        void Update(VotosDTO votosDTO);
        void Remove(VotosDTO votosDTO);
        void Dispose();
    }
}
