using PlanningPoker.Domain.Entities;
using PlanningPoker.Domain.Interfaces.Repositories;
using PlanningPoker.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services
{
   public class ServiceVotos : ServiceBase<Votos>, IServiceVotos
    {
        public readonly IRepositoryVotos _repositoryVotos;

        public ServiceVotos(IRepositoryVotos repositoryVotos) : base(repositoryVotos)
        {
            _repositoryVotos = repositoryVotos;
        }
    }
}
