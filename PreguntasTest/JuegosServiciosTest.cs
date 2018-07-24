using JuegoTrivia;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PreguntasTest
{
    [TestClass]
    public class JuegosServiciosTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            JuegoServicio service = new JuegoServicio();

            var result = service.GetUsuario();

                Assert.IsNotNull(result);


            
        }
        [TestMethod]
        public void TestMethod()
        {

            JuegoServicio service = new JuegoServicio();

            var result = service.Search(2);

            Assert.IsNotNull(result);



        }
    }
}
