using System;

namespace ETSFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha1 = new DateTime(2003, 01, 01);
            var fecha2 = DateTime.Today;
            DateTime[] listaFechas = { fecha1, fecha2 };

            DiferenciasAños.datos[] allfechas = new DiferenciasAños.datos[2];

            allfechas[0].anno = 2000;
            allfechas[0].mes = 12;
            allfechas[0].dia = 30;
            allfechas[0].ACDC = 0;

            allfechas[1].anno = 1920;
            allfechas[1].mes = 6;
            allfechas[1].dia = 20;
            allfechas[1].ACDC = 1;

            DiferenciasAños.DifferenceYear(allfechas);
        }
    }
}
