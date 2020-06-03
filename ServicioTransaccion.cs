using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using System.Transactions;

namespace Tarea_lll_
{
    public class ServicioTransaccion : Transaccion , InterF
    {
        MenuPrincipal menuPrincipal = new MenuPrincipal();
       

        public void Add()
        {
            Console.Clear(); 

            var idListA = new List<int>();

            var idListR = new List<int>();

            foreach (Aprobada item in Repositorio.Instancia.aprobadas)
            {
                idListA.Add(item.ID);
            }
            foreach (Rechazadas item in Repositorio.Instancia.rechazadas)
            {
                idListR.Add(item.ID);
            }

            Console.WriteLine("Que tipo de transaccion desea realizar?: \n 1-Aprobada\n 2-Rechazada ");
            int transaccion = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); 

            Console.WriteLine("Ingrese el nombre del Cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.WriteLine("Ingrese el monto de la transferencia: ");
            int montoTransaccion = Convert.ToInt32(Console.ReadLine());

            if (transaccion == 1)
            {


                this.ID = 101010;

                if (idListA.Count > 0)
                {
                    ID = idListA[^1] + 1;

                }



                Aprobada nuevaTransaccion = new Aprobada(nombreCliente, montoTransaccion, ID, transaccion);

                Repositorio.Instancia.aprobadas.Add(nuevaTransaccion);
                Console.WriteLine("Se ha agregado con exito");
                menuPrincipal.ImprimirMenu();
            }
            if (transaccion == 2)
            {
                int id = 101020;
                if (idListR.Count > 0)
                {
                    id = idListR[^1] + 1;

                }

                Rechazadas nuevaTransaccion = new Rechazadas(nombreCliente, montoTransaccion, id, transaccion);

                Repositorio.Instancia.rechazadas.Add(nuevaTransaccion);
                Console.WriteLine("Se ha agregado con exito");
                menuPrincipal.ImprimirMenu();
            }
        }

        public void Delete()
        {
            Console.Clear();
                
            Console.WriteLine("Seleccione la transaccion que desea eliminar:");
            Console.WriteLine("1- Aprobada");
            Console.WriteLine("2- Rechazada");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Clear();
                Console.WriteLine("***Listado de transacciones Aprobadas***");
                foreach (Aprobada item in Repositorio.Instancia.aprobadas)
                {
                    Console.WriteLine("-ID de transaccion: " + item.ID + " *Cliente: " + item.NombreCliente + " *Monto transferido: " + item.MontoTransaccion + " *Transaccion aprobada.");
                }
                Console.Write("Ingrese el ID que desea remover: ");
                int idA = Convert.ToInt32(Console.ReadLine());
                int position = Repositorio.Instancia.aprobadas.FindIndex(a => a.ID == idA);
                var elemento = Repositorio.Instancia.aprobadas.Find(a => a.ID == idA);
                Canceladas newCancel = new Canceladas(elemento.ID, elemento.NombreCliente, elemento.MontoTransaccion, opcion);
                Repositorio.Instancia.canceladas.Add(newCancel);
                Repositorio.Instancia.aprobadas.RemoveAt(position);



            } else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("***Listado de transacciones Rechazadas***");
                foreach (Rechazadas item in Repositorio.Instancia.rechazadas)
                {
                    Console.WriteLine("-ID de transaccion: " + item.ID + " *Cliente: " + item.NombreCliente + " *Monto transferido: " + item.MontoTransaccion + " *Transaccion rechazada.");

                }
                Console.Write("Ingrese el ID que desea remover: ");
                int idR = Convert.ToInt32(Console.ReadLine());
                int position = Repositorio.Instancia.rechazadas.FindIndex(r => r.ID == idR);
                var elemento = Repositorio.Instancia.rechazadas.Find(r => r.ID == idR);
                Eliminadas newCancel = new Eliminadas(elemento.ID, elemento.NombreCliente, elemento.MontoTransaccion, opcion);
                Repositorio.Instancia.eliminadas.Add(newCancel);
                Repositorio.Instancia.rechazadas.RemoveAt(position);
            }

            Console.WriteLine();
            Console.ReadKey();
            menuPrincipal.ImprimirMenu();

        }

        public void Edit()
        {

            Console.Clear();
            Console.WriteLine("Ingrese el ID de la transaccion que desea editar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            for (var c = 0; c < Repositorio.Instancia.aprobadas.Count; c++)
            {

                if (Repositorio.Instancia.aprobadas[c].ID == id)
                {
                    Console.Clear();
                    Console.WriteLine(Repositorio.Instancia.aprobadas[c].ID);
                    Console.ReadKey();

                    Console.WriteLine("Ingrese el nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();

                    Console.WriteLine("Ingrese el monto: ");
                    int montoTransaccion = Convert.ToInt32(Console.ReadLine());

                    Aprobada transaccionEdit = new Aprobada(nombreCliente, montoTransaccion, id);

                    Repositorio.Instancia.aprobadas[ID] = transaccionEdit;

                    Console.WriteLine("se ha editado con exito.");
                    Console.ReadKey();
                    menuPrincipal.ImprimirMenu();
                }
                else
                {
                    Console.WriteLine("ID de transaccion no valido.");
                    Console.ReadKey();
                    Console.WriteLine("Desea buscar otro ID? s/n");
                    string opcion = Console.ReadLine();
                    if (opcion == "s")
                    {
                        Edit();

                    }
                    else
                    {
                        menuPrincipal.ImprimirMenu();
                    }
                }


            }
            for (var c = 0; c < Repositorio.Instancia.rechazadas.Count; c++)
            {

                if (Repositorio.Instancia.rechazadas[c].ID == id)
                {

                    Console.Clear();
                    Console.WriteLine(Repositorio.Instancia.rechazadas[c].ID);
                    Console.ReadKey();

                    Console.WriteLine("Ingrese el nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();

                    Console.WriteLine("Ingrese el monto: ");
                    int montoTransaccion = Convert.ToInt32(Console.ReadLine());

                    Rechazadas transaccionEdit = new Rechazadas(nombreCliente, montoTransaccion, id);

                    Repositorio.Instancia.rechazadas[ID] = transaccionEdit;

                    Console.WriteLine("se ha editado con exito.");
                    Console.ReadKey();
                    menuPrincipal.ImprimirMenu();
                }
                else
                {
                    Console.WriteLine("ID de transaccion no valido.");
                    Console.ReadKey();
                    Console.WriteLine("Desea buscar otro ID? s/n");
                    string opcion = Console.ReadLine();
                    if (opcion == "s")
                    {
                        Edit();

                    }
                    else
                    {
                        menuPrincipal.ImprimirMenu();
                    }
                }
            }


        }




        public void Read()
        {
            Console.Clear();
            Console.WriteLine("***Listado de transacciones***");
            Console.WriteLine();
           
            foreach (Aprobada item in Repositorio.Instancia.aprobadas)
            {
                Console.WriteLine("-ID de transaccion: " + item.ID+ " *Cliente: " + item.NombreCliente + " *Monto transferido: " + item.MontoTransaccion + " *Transaccion aprobada.");
                
            }
            Console.WriteLine();
          
            foreach (Rechazadas item in Repositorio.Instancia.rechazadas)
            {
                Console.WriteLine("-ID de transaccion: " + item.ID + " *Cliente: " + item.NombreCliente + " *Monto transferido: " + item.MontoTransaccion + " *Transaccion rechazada.") ;
                
            }
            
            foreach (Canceladas item in Repositorio.Instancia.canceladas)
            {
                Console.WriteLine( "-ID de transaccion: " + item.ID + " *Cliente: " + item.NombreCliente + " *Monto transferido: " + item.MontoTransaccion + " *Transaccion cancelada.");
               
            }
            Console.WriteLine();
            
            foreach (Eliminadas item in Repositorio.Instancia.eliminadas)
            {
                Console.WriteLine("-ID de transaccion: " + item.ID + " *Cliente: " + item.NombreCliente + " *Monto transferido: " + item.MontoTransaccion + " *Transaccion eliminada.");
                
            }
            Console.WriteLine();
            Console.ReadKey();
            menuPrincipal.ImprimirMenu();
        }
    }
}
    
