using PlanningPoker.Domain.Core.Interfaces.Repositories;
using PlanningPoker.Domain.Core.Interfaces.Services;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services.Services
{
   public class ServiceHistorias : ServiceBase<Historias>, IServiceHistorias
    {
        public readonly IRepositoryHistorias _repositoryHistorias;

        public ServiceHistorias(IRepositoryHistorias repositoryHistorias) : base(repositoryHistorias)
        {
            _repositoryHistorias = repositoryHistorias;
        }
    }
}
