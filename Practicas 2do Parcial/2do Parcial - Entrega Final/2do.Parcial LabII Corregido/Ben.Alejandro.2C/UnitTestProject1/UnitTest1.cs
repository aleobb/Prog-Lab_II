using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using EntidadesHechas;
using _20171123_SP_Cartas;

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
            catch(Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(TrackingIdRepetidoException));
            }
/*            catch (TrackingIdRepetidoException e)
            {
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }*/
        }
    }
}
