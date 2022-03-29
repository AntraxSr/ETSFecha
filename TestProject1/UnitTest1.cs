using ETSFecha;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Comprobamos si los años se calculan bien
        /// La funcion calcula los años antes de cristo
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Program.Fecha fechas = new Program.Fecha();

            fechas.Anno = 1900;
            fechas.Mes = 2;
            fechas.Dia = 10;
            fechas.ACDC = 0;

            DateTime fecha = new DateTime(fechas.Anno, fechas.Mes, fechas.Dia);

            Assert.AreEqual(Dates.CalcularAnnosAC(fecha), 3922);

        }
        /// <summary>
        /// Debería devolver 0 años ya que la fecha está bastante cerca.
        /// La función es calcular años despues de cristo.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Program.Fecha fechas = new Program.Fecha();

            fechas.Anno = 2022;
            fechas.Mes = 2;
            fechas.Dia = 1;
            fechas.ACDC = 1;

            DateTime fecha = new DateTime(fechas.Anno, fechas.Mes, fechas.Dia);

            Assert.AreEqual(Dates.CalcularAnnoDC(fecha), 0);
        }
        /// <summary>
        /// Tiene que ser incorrecto ya que los años están mal puestos.
        /// La funcion debería devolver 0 años ya que es una fecha próxima.
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            Program.Fecha fechas = new Program.Fecha();

            fechas.Anno = 2022;
            fechas.Mes = 2;
            fechas.Dia = 1;
            fechas.ACDC = 1;

            DateTime fecha = new DateTime(fechas.Anno, fechas.Mes, fechas.Dia);

            Assert.AreNotEqual(Dates.CalcularAnnoDC(fecha), 1000);
        }
        /// <summary>
        /// Esta funcion debería devolverle los días de la fecha puesta hasta el día de hoy
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            Program.Fecha fechas = new Program.Fecha();

            fechas.Anno = 2022;
            fechas.Mes = 2;
            fechas.Dia = 1;
            fechas.ACDC = 1;

            DateTime fecha = new DateTime(fechas.Anno, fechas.Mes, fechas.Dia);

            Assert.AreEqual(Dates.CalcularDia(fecha), 56);
        }
        /// <summary>
        /// Aquí igual solo que le ponemos una fecha AC y ebería devolver el valor de 13 días.
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            Program.Fecha fechas = new Program.Fecha();

            fechas.Anno = 1900;
            fechas.Mes = 2;
            fechas.Dia = 10;
            fechas.ACDC = 0;

            DateTime fecha = new DateTime(fechas.Anno, fechas.Mes, fechas.Dia);

            Assert.AreEqual(Dates.CalcularDia(fecha), 47);
        }

        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de años de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            Program.Fecha[] fechas = new Program.Fecha[2];

            fechas[0].Anno = 1900;
            fechas[0].Mes = 2;
            fechas[0].Dia = 10;
            fechas[0].ACDC = 0;

            fechas[1].Anno = 1900;
            fechas[1].Mes = 2;
            fechas[1].Dia = 11;
            fechas[1].ACDC = 1;

            string[] resultados = { "3800", "1" };

            Assert.AreEqual(DiferenciasAnnos.DifferenceYear(fechas)[0],resultados[0]);
        }

        /// <summary>
        /// Se comprueba que se devuelva el valor correcto del calculo de días de diferencia
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            Program.Fecha[] fechas = new Program.Fecha[2];

            fechas[0].Anno = 1900;
            fechas[0].Mes = 2;
            fechas[0].Dia = 10;
            fechas[0].ACDC = 0;

            fechas[1].Anno = 1900;
            fechas[1].Mes = 2;
            fechas[1].Dia = 11;
            fechas[1].ACDC = 1;

            string[] resultados = { "3800", "1" };

            Assert.AreEqual(DiferenciasAnnos.DifferenceYear(fechas)[1], resultados[1]);
        }
    }
}
