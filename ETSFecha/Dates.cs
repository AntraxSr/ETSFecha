using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSFecha
{
    class Dates
    {
        public static void ComprobarInformacion(Program.Fecha[] fechasComprobar)
        {
            for (int contador = 0; contador < fechasComprobar.Length; contador++)
            {
                if (fechasComprobar[contador].AntesODespues == 0)
                {
                    DateTime fecha = new DateTime(fechasComprobar[contador].Anno, fechasComprobar[contador].Mes, fechasComprobar[contador].Dia);
                    DateTime fechaHoy = DateTime.Today;

                    int dias = ((fechaHoy.Day) - fechasComprobar[contador].Dia);
                    int anno = fechasComprobar[contador].Anno + fechaHoy.Year;

                    Console.WriteLine("Hay " + anno + " años y " + dias + " días de diferencia en la fecha número {0}",contador + 1);
                }
                else
                {

                }
            }
        }

        private static int CalcularAnnosAC(DateTime fecha)
        {
            DateTime fechaHoy = DateTime.Today;
            int anno = (fecha.Year + fechaHoy.Year);

            return anno; 
        }









        //bool correct = DateTime.IsLeapYear(400);


    }
}
