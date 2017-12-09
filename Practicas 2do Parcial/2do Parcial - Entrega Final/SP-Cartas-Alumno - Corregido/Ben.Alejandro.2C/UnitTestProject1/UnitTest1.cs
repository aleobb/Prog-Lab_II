using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EntidadesHechas;
using _20171123_SP_Cartas;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Correo c = new Correo();

            Assert.IsInstanceOfType(c.Paquetes, typeof(List<Paquete>));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Correo c = new Correo();

            Paquete p1 = new Paquete("dir", "50");
            Paquete p2 = new Paquete("dir", "50");

            try
            {
                c += p1;
                c += p2;
            }
            catch (TrackingIdRepetidoException e)
            {
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void NoCargarDosTrackingIDIguales()
        {
            string
                track = "123456478",
                dir = "Rivadavia 1";
            Correo correo = new Correo();
            Paquete paquete = new Paquete(dir, track);
            correo = correo + paquete;
            Paquete paquete2 = new Paquete(dir, track);
            correo = correo + paquete2;
        }

    }
}
