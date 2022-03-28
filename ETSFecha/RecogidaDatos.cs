using System;

namespace ETSFecha
{
    class TomaDatos
    {
        /// <summary>
        /// Programa para verificar el formato de la recogida de datos 
        /// </summary>
        /// <returns>Devuelve las fechas en un array de estructura</returns>
        public static Program.Fecha[] UsoStruct()
        {
            Program.Fecha[] fechas = new Program.Fecha[2];

            for (int llenarFechas = 0; llenarFechas < 2; llenarFechas++)
            {
                bool bisiesto = false;
                fechas[llenarFechas].ACDC = RecogidaCristo();
                fechas[llenarFechas].Anno = RecogidaAgno(ref bisiesto);
                fechas[llenarFechas].Mes = RecogidaMes();
                fechas[llenarFechas].Dia = RecogidaDia(bisiesto, fechas[llenarFechas].Mes);
            }

            return fechas;
        }

        /// <summary>
        /// Pide y comprueba si es antes de cristo o después de cristo.
        /// </summary>
        /// <returns>1 si es antes de cristo o 0 si es después de cristo</returns>
        private static int RecogidaCristo()
        {
            bool seguirPidiendo = true;
            int cristo = -1;

            while (seguirPidiendo)
            {

                Console.WriteLine("Introduce '1' si el año es antes de cristo y '0' si es después: ");
                string cadena = Console.ReadLine();

                if (int.TryParse(cadena, out cristo))
                {
                    if (cristo == 0)
                    {
                        seguirPidiendo = false;
                    }
                    else
                    {
                        if (cristo == 1)
                        {
                            seguirPidiendo = false;
                        }
                        else
                        {
                            Console.WriteLine("Has respondido de forma errónea. Vuelva a intertarlo.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se ha introducido un número");
                }

            }
            return cristo;
        }

        /// <summary>
        /// Pide un año y comprueba si es válido.
        /// </summary>
        /// <param name="bisiesto">Booleano que almacena si es bisiesto o no</param>
        /// <returns>Retorna el año</returns>
        private static int RecogidaAgno(ref bool bisiesto)
        {
            bool seguirPidiendo = true;
            int numeroAgno = 0;

            while (seguirPidiendo)
            {
                Console.WriteLine("Introduce un año:");
                string recogidaAgno = Console.ReadLine();

                if (Int32.TryParse(recogidaAgno, out numeroAgno))
                {
                    if (numeroAgno < 10000)
                    {
                        if (numeroAgno >= 1)
                        {
                            if (numeroAgno % 4 == 0 && numeroAgno % 100 != 0 || numeroAgno % 400 == 0)
                            {
                                bisiesto = true;
                            }
                            seguirPidiendo = false;
                        }
                        else
                        {
                            Console.WriteLine("El valor 0 y los número negativos no son válidos para establecer el año.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El formato de año introducido no es válido.");
                    }
                }
                else
                {
                    Console.WriteLine("No has introducido un número.");
                }
            }
            return (numeroAgno);
        }

        /// <summary>
        /// Pide un mes y comprueba si es válido.
        /// </summary>
        /// <returns>Devuelve el valor del mes</returns>
        private static int RecogidaMes()
        {
            bool seguirPidiendo = true;
            int numeroMes = 0;

            while (seguirPidiendo)
            {
                Console.WriteLine("Introduce un mes: (En formato numérico)");
                string recogidaMes = Console.ReadLine();

                if (Int32.TryParse(recogidaMes, out numeroMes))
                {
                    if (numeroMes < 13)
                    {
                        if (numeroMes >= 1)
                        {

                            seguirPidiendo = false;
                        }
                        else
                        {
                            Console.WriteLine("El valor 0 y los número negativos no son válidos para establecer el mes.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El formato de mes introducido no es válido.");
                    }
                }
                else
                {
                    Console.WriteLine("No has introducido un número.");
                }
            }
            return numeroMes;
        }

        /// <summary>
        /// Pide dias y comprueba si es válido.
        /// </summary>
        /// <param name="bisiesto">Se le pasa el booleano para, en caso de que el mes sea febrero, aceptar los dias 29</param>
        /// <param name="mes">Numero de mes</param>
        /// <returns>Retorna el día comprobado</returns>
        private static int RecogidaDia(bool bisiesto, int mes)
        {
            bool seguirPidiendo = true;
            int numeroDia = 0;

            while (seguirPidiendo)
            {
                Console.WriteLine("Introduce un día: (En formato numérico)");
                string recogidaDia = Console.ReadLine();

                if (Int32.TryParse(recogidaDia, out numeroDia))
                {
                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (numeroDia >= 1 && numeroDia <= 31)
                        {
                            seguirPidiendo = false;
                        }
                        else
                        {
                            Console.WriteLine("El día introducido no concuerda con el mes establecido.");
                        }
                    }
                    else
                    {
                        if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                        {
                            if (numeroDia >= 1 && numeroDia <= 30)
                            {
                                seguirPidiendo = false;
                            }
                            else
                            {
                                Console.WriteLine("El día introducido no concuerda con el mes establecido.");
                            }
                        }

                        if (mes == 2)
                        {
                            if (!bisiesto)
                            {
                                if (numeroDia >= 1 && numeroDia <= 28)
                                {
                                    seguirPidiendo = false;
                                }
                                else
                                {
                                    Console.WriteLine("El día introducido no concuerda con el mes establecido.");
                                }
                            }
                            else
                            {
                                if (numeroDia >= 1 && numeroDia <= 29)
                                {
                                    seguirPidiendo = false;
                                }
                                else
                                {
                                    Console.WriteLine("El día introducido no concuerda con el mes establecido.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No has introducido un número.");
                }
                Console.ReadKey();
            }
            return numeroDia;
        }

    }
}
