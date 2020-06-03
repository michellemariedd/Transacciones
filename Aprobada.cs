using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_lll_
{
    public class Aprobada : Transaccion
    {
        public string NombreCliente { get; set; }

        public int MontoTransaccion { get; set; }

        public int Transaccion { get; set; }
    
        public Aprobada(string nombreCliente, int montoTransaccion, int ID, int transaccion) : base()
        {
             this.ID = ID;
            this.Transaccion = transaccion;
            this.NombreCliente = nombreCliente;
            this.MontoTransaccion = montoTransaccion;

        }
        public Aprobada(string nombreCliente , int montoTransaccion, int ID) 
        {
            this.ID = ID;
            this.NombreCliente = nombreCliente;
            this.MontoTransaccion = montoTransaccion;

        }

        public Aprobada()
        {
        }
    }
}
