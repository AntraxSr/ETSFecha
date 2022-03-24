using System;

namespace ETSFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            DiferenciasAnnos.datos[] allfechas = new DiferenciasAnnos.datos[2];

            allfechas[0].anno = 2000;
            allfechas[0].mes = 12;
            allfechas[0].dia = 30;
            allfechas[0].ACDC = 0;

            allfechas[1].anno = 1920;
            allfechas[1].mes = 6;
            allfechas[1].dia = 20;
            allfechas[1].ACDC = 1;

            Console.WriteLine("buenos días");

            string[] resultado = DiferenciasAnnos.DifferenceYear(allfechas);

            Console.WriteLine("La diferencia en años es de: " + resultado[0] + " y en dias: " + resultado[1]);
            Console.ReadKey();
        }
    }
}
