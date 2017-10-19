using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CentralitaHerencia;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a_ListaDeLlamadasInstanciada()
        {
            Centralita c = new Centralita("test llamadas");
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        public void b_ExceptionLocal()
        {
            try
            {
                Centralita c = new Centralita();

                Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
                Local l2 = new Local("Bernal", 30, "Rosario", 2.65f);

                c += l1;
                c += l2;
            }
            catch(CentralitaException e)
            {
                Assert.IsInstanceOfType(e,typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void c_ExceptionProvincial()
        {
            try
            {
                Centralita c = new Centralita();

                Provincial p1 = new Provincial("bernal", Provincial.Franja.Franja_2, 3.45f, "avell");
                Provincial p2 = p1;
                c += p1;
                c += p2;
            }
            catch(CentralitaException e)
            {
                Assert.IsInstanceOfType(e,typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void d_ObjetosIguales()
        {
            Centralita c = new Centralita();

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 130, "Rosario", 2.35f);

            Provincial p1 = new Provincial("Bernal", Provincial.Franja.Franja_2, 3.45f, "Rosario");
            Provincial p2 = new Provincial("Bernal", Provincial.Franja.Franja_3, 3.85f, "Rosario");

            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);

            Assert.IsFalse(l2 == p1);
            Assert.IsFalse(l2 == p2);

            Assert.IsTrue(p1 == p2);


            // A continuacion otra forma de testearlo pero prestando atencion a que deberia estar bien el metodo + que se usa abajo: 
            /*
            c += l1; // el problema aca es que no me va a dejar cargar 2 llamadas con igual origen y destino porque eso es lo que evalua el ==
            c += l2;
            c += p1;
            c += p2;

            foreach (Llamada llamada in c.Llamadas)
            {
                foreach (Llamada l in c.Llamadas)
                {
                    if (object.Equals(llamada.GetType(), l.GetType()))
                        Assert.IsTrue(l == llamada);
                    else
                        Assert.IsFalse(l == llamada);
                }
            }
             */
        }

    }
}
