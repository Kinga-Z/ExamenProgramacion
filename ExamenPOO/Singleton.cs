using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPOO
{
    public class Singleton
    {
        //Atributos
        private static Singleton Creacion; 
        public int Dinero { get; set; }
        
        //Constructor Privado
        private Singleton() { }

        //Creamos un metodos para crear la clase
        public static Singleton GetCreacion() 
        {
            //Comprueba si la clase esta creada o no : Si se encuentrada creada devolverá la clase creada , si no ha sido creada
            //Se creara una nueva
            if (Creacion == null)
            {
                Creacion = new Singleton();
            }
            return Creacion;
        }
        //Creamos un metodos para Ingresar el dinero
        public void IngresarDinero(int Dinero)
        {
            this.Dinero += Dinero;
        }
    }
}
