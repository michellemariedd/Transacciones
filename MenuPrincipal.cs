using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_lll_
{
    enum Opciones
    { 
      REA_TRA = 1,
      EDIT,
      DELETE,
      READ,
      EXIT,
    }
    public class MenuPrincipal
    {
        public void ImprimirMenu() 
        {
            

            InterF service = new ServicioTransaccion();

           
            try
            {
                Console.Clear();
                Console.WriteLine("***Transacciones***");
                Console.WriteLine(" 1-Realizar Transaccion\n 2-Editar Transaccion\n 3-Eliminar Transaccion\n 4-Listar Transaccion\n 5-Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)Opciones.REA_TRA:
                        service.Add();
                        break;
                    case (int)Opciones.EDIT:
                        service.Edit();
                        break;
                    case (int)Opciones.DELETE:
                        service.Delete();
                        break;
                    case (int)Opciones.READ:
                        service.Read();
                        break;
                    case (int)Opciones.EXIT:
                        Console.WriteLine("Gracias por utilizar el sistema de transaccion.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe seleccionar una opcion valida.");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Debe seleccionar una opcion valida.");
                Console.ReadKey();
            }
        }
    }
}
