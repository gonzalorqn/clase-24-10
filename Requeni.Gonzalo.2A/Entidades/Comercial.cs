using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Comercial : Avion
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio,double velocidad,int pasajeros) : base(precio,velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }
    }
}