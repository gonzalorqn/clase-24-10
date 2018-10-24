using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Carreta : Vehiculo , IARBA
    {
        public Carreta(double precio) : base(precio)
        {

        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.18;
        }
    }
}