using PlanningPoker.Domain.Core.Interfaces.Repositories;
using PlanningPoker.Domain.Core.Interfaces.Services;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services.Services
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
