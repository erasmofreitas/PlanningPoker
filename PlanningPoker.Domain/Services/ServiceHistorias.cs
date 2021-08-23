using PlanningPoker.Domain.Entities;
using PlanningPoker.Domain.Interfaces.Repositories;
using PlanningPoker.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services
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
