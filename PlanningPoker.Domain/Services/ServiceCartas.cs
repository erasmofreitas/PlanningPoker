using PlanningPoker.Domain.Entities;
using PlanningPoker.Domain.Interfaces.Repositories;
using PlanningPoker.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Services
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
