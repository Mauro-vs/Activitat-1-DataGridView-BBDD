using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activitat_1_DataGridView_mauro
{
    public class Ingreso
    {
        private static int contadorId = 0;
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Motivo { get; set; }
        public string Especialidad { get; set; }
        public string Habitacion { get; set; }

        public Ingreso()
        {
            contadorId++;
            Id = contadorId;
        }
    }
}
