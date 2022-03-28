using System;

namespace ETSFecha
{
    public class Dates
    {
        public static void ComprobarInformacion(Program.Fecha[] fechasComprobar)
        {
            for (int contador = 0; contador < fechasComprobar.Length; contador++)
            {
                DateTime fecha = new DateTime(fechasComprobar[contador].Anno, fechasComprobar[contador].Mes, fechasComprobar[contador].Dia);
                DateTime fechaHoy = DateTime.Today;

                if (fechasComprobar[contador].ACDC == 0)
                {
                    int anno = CalcularAnnosAC(fecha);
                    int dia = CalcularDia(fecha);

                    Console.WriteLine("Hay " + anno + " años y " + dia + " días de diferencia en la fecha número {0}", contador + 1);
                    Console.WriteLine("Pulse una tecla para continuar");
                    Console.ReadKey();
                }
                else
                {
                    int anno = CalcularAnnoDC(fecha);
                    int dia = CalcularDia(fecha);

                    Console.WriteLine("Hay " + anno + " años y " + dia + " días de diferencia en la fecha número {0}", contador + 1);
                    Console.WriteLine("Pulse una tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
        public static int CalcularAnnosAC(DateTime fecha)
        {
            DateTime fechaHoy = DateTime.Today;
            int anno = (fecha.Year + fechaHoy.Year);

            return anno;
        }
        public static int CalcularAnnoDC(DateTime fecha)
        {
            DateTime fechaHoy = DateTime.Today;
            int anno = 0;

            if (fecha.Year < fechaHoy.Year)
            {
                anno = fechaHoy.Year - fecha.Year;
            }
            else
            {
                anno = fecha.Year - fechaHoy.Year;
            }
            return anno;
        }
        public static int CalcularDia(DateTime fecha)
        {
            DateTime fechaHoy = DateTime.Today;
            int dia = 0;

            DateTime fechaProvisional = new DateTime(1, fecha.Month, fecha.Day);
            DateTime fechaTodayProvisional = new DateTime(1, fechaHoy.Month, fechaHoy.Day);

            if (fechaProvisional < fechaTodayProvisional)
            {
                dia = (fechaTodayProvisional - fechaProvisional).Days;
            }
            else
            {
                dia = (fechaProvisional - fechaTodayProvisional).Days;
            }
            return dia;
        }
    }
}
