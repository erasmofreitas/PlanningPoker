using PlanningPoker.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Application.Interfaces
{
   public interface IUsuariosApplication
    {
        void Add(UsuariosDTO usuariosDTO);
        UsuariosDTO GetById(int id);
        IEnumerable<UsuariosDTO> GetAll();
        void Update(UsuariosDTO usuariosDTO);
        void Remove(UsuariosDTO usuariosDTO);
        void Dispose();
    }
}
