using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Auto: Vehiculo
    {
        protected string _patente;

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }

        public Auto(double precio,string patente) : base(precio)
        {
            this._patente = patente;
        }
    }
}