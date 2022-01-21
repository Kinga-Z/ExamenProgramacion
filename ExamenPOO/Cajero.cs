using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPOO
{
    public class Cajero
    {
        //Atributos
        int Dinero { get; set; }
        int ID;
        //Constructor 
        public Cajero(int id) { this.ID = id; }

        //Realizamos el almacenamiento del pago por el cliente y  Devolvemos la diferencia 
        public int Monto(int Dinero, int MontoPagar)
        {
            int Diferencia =  MontoPagar - Dinero;
            this.Dinero += Diferencia;
            this.Dinero = +Dinero;
            return Diferencia;
        }
        public void EnviarDineroBoveda()
        {
            Singleton BovedaDinero = Singleton.GetCreacion();
            BovedaDinero.IngresarDinero(this.Dinero);
            this.Dinero = 0;
        }
    }
}
