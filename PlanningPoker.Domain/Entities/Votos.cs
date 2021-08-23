using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Entities
{
    public class Votos : EntityBase
    {
        public int UsuarioId { get; set; }
        public int CartasId { get; set; }
        public int HistoriasId { get; set; }
        public Usuarios Usuarios { get; set; }
        public Cartas Cartas { get; set; }
        public Historias Historias { get; set; }
    }
}
