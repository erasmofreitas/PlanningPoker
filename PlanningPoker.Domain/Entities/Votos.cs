using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Entities
{
    public class Votos : EntityBase
    {
        public int UsuarioId { get; set; }
        public int CartaId { get; set; }
        public int HistoriaId { get; set; }
        public Usuarios Usuarios { get; set; }
        public Cartas Cartas { get; set; }
        public Historias Historias { get; set; }
    }
}
