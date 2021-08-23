using PlanningPoker.Data.Contexts;
using PlanningPoker.Domain.Entities;
using PlanningPoker.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Data.Repositories
{
   public class RepositoryHistorias : RepositoryBase<Historias>, IRepositoryHistorias
    {
        private readonly SqlContext _context;
        public RepositoryHistorias(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
