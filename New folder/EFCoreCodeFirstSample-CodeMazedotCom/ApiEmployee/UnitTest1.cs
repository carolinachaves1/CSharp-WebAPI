using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiEmployee
{
    [TestClass]//classe de um conjunto de teste
    public class UnitTest1
    {
        
        [TestInitialize]//primeiro método a ser executado
        public void IniciarTeste()
        {

        }

        [TestMethod]//para cada método, um teste
        public void TestMethod1()
        {
        }

        [TestCleanup]
        public void FinalizarTeste()
        {

        }
    }
}
