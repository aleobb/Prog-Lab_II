using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using Test;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a_ListaDeLlamadasInstanciada()
        {
            Centralita c = new Centralita("test llamadas");
            Assert.IsNull(c.Llamadas);
        }

        [TestMethod]
        public void b_CentralitaException()
        {
            Centralita c = new Centralita();

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 30, "Rosario", 2.65f);

            c += l1;
            c += l2;

           // Assert.ThrowsException<CentralitaException>(c+l2,"algo");
        }



    }
}
