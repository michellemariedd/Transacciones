﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_lll_
{
   public  class Canceladas 
    {
        public int ID { get; set; }

        public string NombreCliente { get; set; }

        public int MontoTransaccion { get; set; }

        public int Transaccion { get; set; }


        public Canceladas(int ID, string nombreCliente, int montoTransaccion, int transaccion) : base()
        {
            this.ID = ID;
            this.NombreCliente = nombreCliente;
            this.MontoTransaccion = montoTransaccion;
            this.Transaccion = transaccion;
        
        }
    }
}
