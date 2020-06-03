using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_lll_
{
   public  class ListaTransaccion : Transaccion 
    {
        Rechazadas rechazadas = new Rechazadas();
        Aprobada aprobada = new Aprobada();

        public void Read() 
        {
            rechazadas.Read();

            aprobada.Read();


        }
    }
}
