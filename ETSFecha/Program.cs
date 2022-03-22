using System;

namespace ETSFecha
{
    class Program
    {
        public struct Fecha
        {
            public int Anno;
            public int Mes;
            public int Dia;
            public int AntesODespues; 
        }

        static void Main(string[] args)
        {
            Fecha[] fechas = new Fecha[2];

            fechas[0].Anno = 1900;
            fechas[0].Mes = 2;
            fechas[0].Dia = 10;
            fechas[0].AntesODespues = 0;


            Dates.ComprobarInformacion(fechas);
        }
    }
}
