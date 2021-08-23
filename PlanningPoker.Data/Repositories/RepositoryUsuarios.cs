using PlanningPoker.Data.Contexts;
using PlanningPoker.Domain.Entities;
using PlanningPoker.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Data.Repositories
{
   public class RepositoryUsuarios : RepositoryBase<Usuarios>, IRepositoryUsuarios
    {
        private readonly SqlContext _context;
        public RepositoryUsuarios(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
