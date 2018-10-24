using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- IMPLEMENTAR IAFIP.CALCULARIMPUESTO(AVION(33% PRECIO) - DEPORTIVO(28% PRECIO))
            //2- VERIFICAR SI LA IMPLEMENTACION SE HEREDA (ENTRE AVION <-- PRIVADO - COMERCIAL)
            //3- CREAR PROPIEDADES:
            // A)ABSTRACTAS - DONDE CORRESPONDA
            // B)VIRTUALES - DONDE CORRESPONDA
            // C)EN LA INTERFACE IAFIP
            //4- IMPLEMENTAR EL METODO GESTION.MOSTRARIMPUESTONACIONAL

            Privado p1 = new Privado(15000, 250, 10);
            Comercial c1 = new Comercial(12000, 200, 100);
            double impuestoAvionPrivado = Gestion.MostrarImpuestoNacional(p1);
            double impuestoAvionComercial = Gestion.MostrarImpuestoNacional(c1);
            Deportivo d1 = new Deportivo(10000, "AAA 000", 300);
            double impuestoAuto = Gestion.MostrarImpuestoNacional(d1);
            Console.WriteLine("Impuesto avion: " + impuestoAvionPrivado + " - Impuesto auto: " + impuestoAuto);
            Console.ReadLine();
        }
    }
}
