
using PlanningPoker.Domain.Core.Interfaces.Repositories;
using PlanningPoker.Domain.Core.Interfaces.Services;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services.Services
{
    public class ServiceCartas : ServiceBase<Cartas>, IServiceCartas
    {
        public readonly IRepositoryCartas _repositoryCartas;

        public ServiceCartas(IRepositoryCartas repositoryCartas) : base(repositoryCartas)
        {
            _repositoryCartas = repositoryCartas;
        }
    }
}
