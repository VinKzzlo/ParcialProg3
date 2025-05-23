using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftProgDomain.RRHH;
using SoftProgPersistance.RRHH.DAO;
using SoftProgPersistance.RRHH.Impl;

namespace SoftProgTests
{
    [TestClass]
    public class AreaDAOTest
    {
        private static AreaDAO daoArea;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        { 
            daoArea = new AreaImpl();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Area area = new Area("FINANZAS");
            int resultado = daoArea.insertar(area);
            Assert.IsTrue(resultado != 0);
        }
    }
}
