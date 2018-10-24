using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            double retorno = 0;
            if(bienPunible is Deportivo || bienPunible is Avion)
            {
                retorno = ((IAFIP)bienPunible).CalcularImpuesto();
            }
            return retorno;
        }

        public static double MostrarImpuestoProvincial(IARBA bienPunible)
        {
            double retorno = 0;
            if (bienPunible is Deportivo || bienPunible is Avion || bienPunible is Carreta)
            {
                retorno = ((IARBA)bienPunible).CalcularImpuesto();
            }
            return retorno;
        }
    }
}
