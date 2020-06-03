using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Tarea_lll_
{
    public sealed class Repositorio
    {
        
        public List<Aprobada> aprobadas { get; set; } = new List<Aprobada>();

        public List<Rechazadas> rechazadas { get; set; } = new List<Rechazadas>();

        public List<Canceladas> canceladas { get; set; } = new List<Canceladas>();

        public List<Eliminadas> eliminadas { get; set; } = new List<Eliminadas>();

        public static Repositorio Instancia { get; } = new Repositorio();

        private Repositorio()
        {

        }

    }
}
