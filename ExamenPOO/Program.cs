using System;
using System.Collections.Generic;
using System.Threading;

namespace ExamenPOO
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Creamos una Boveda para almacenar el dinero
            Singleton BovedadDinero = Singleton.GetCreacion();

            //Creamos una lista para guarda Todos lo cajeros
            List<Cajero> listacajero = new List<Cajero>() ;

            //Creamos Varios Cajeros
            Cajero cajero1 = new Cajero(1);
            Cajero cajero2 = new Cajero(2);
            Cajero cajero3 = new Cajero(3);
            Cajero cajero4 = new Cajero(4);

            //Agregamos  los cajero a la lista
            listacajero.Add(cajero1);
            listacajero.Add(cajero2);
            listacajero.Add(cajero3);
            listacajero.Add(cajero4);

            //Variable
            bool Exit = true ;
            int opcion = 0;
            int opcion2 = 0;

            //Variable usada en opcion de pagar cajero
            int monto;
            int dinero;

            //Comeinzo del programa de cajero
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opción que desear");
                Console.WriteLine("1-Pagar Cajero");
                Console.WriteLine("2-Ver Dinero de Bovedad");
                Console.WriteLine("3-Finalizar Programa");
                opcion = Opcion(3);

                //Opcion Pagar Cajero
                if (opcion == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Cajero Disponible");
                    for(int contado = 0; contado < listacajero.Count; contado++)
                    {
                        Console.WriteLine("Cajero " +(contado+1));
                    }
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Ingrese a que cajero quiere pagar :");
                    opcion2 = Opcion(listacajero.Count);
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Ingrese el monto a pagar :");
                    monto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el dinero para pagar :");
                    dinero = Convert.ToInt32(Console.ReadLine());

                    listacajero[opcion2].Monto(dinero, monto);
                    listacajero[opcion2].EnviarDineroBoveda();

                    Console.WriteLine("Gracias Por su Compra");
                    Thread.Sleep(2000);


                }

                //Opcion Ver dinero De Bovedad
                if (opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("El Dinero TOTAL De La bovedad es : $"+ BovedadDinero.Dinero);
                    Console.WriteLine("Ingrese el cualquier letra o digito para salir");
                    opcion2 = Convert.ToInt32(Console.ReadLine());                  
                }
                
                //Opción Finalizar Programa
                if(opcion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Finalizando Programa");
                    Thread.Sleep(2000);
                    Exit = false;
                }



            } while (Exit);
        }

        public static int Opcion( int ParametroLimite)
        {
            int opcion=0;
            do
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                if(opcion <= 0 || opcion > ParametroLimite)
                {
                    Console.WriteLine("La opcion que ha ingresado no se encuentra , ingrese de nuevo la opción");
                }
            } while (opcion <= 0 || opcion > ParametroLimite);
            return opcion;
        }




    }
}
