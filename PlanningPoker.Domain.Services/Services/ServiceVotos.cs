using PlanningPoker.Domain.Core.Interfaces.Repositories;
using PlanningPoker.Domain.Core.Interfaces.Services;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services.Services
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
