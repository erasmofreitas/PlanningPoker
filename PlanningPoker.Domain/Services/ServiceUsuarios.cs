using PlanningPoker.Domain.Entities;
using PlanningPoker.Domain.Interfaces.Repositories;
using PlanningPoker.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services
{
   public class ServiceUsuarios : ServiceBase<Usuarios>, IServiceUsuarios
    {
        public readonly IRepositoryUsuarios _repositoryUsuarios;

        public ServiceUsuarios(IRepositoryUsuarios repositoryUsuarios) : base(repositoryUsuarios)
        {
            _repositoryUsuarios = repositoryUsuarios;
        }
    }
}
