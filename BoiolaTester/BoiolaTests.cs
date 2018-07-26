using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoiolaTester
{
    [TestFixture]
    public class FabioTests
    {
        Fabio fabio = new Fabio();

        [Test]
        public void NomeCompletodoFabio()
        {
            Assert.AreEqual("Fabio Carvalho", fabio.getFullName());
        }

        [Test]
        public void FabioIsRabeta()
        {
            Assert.IsTrue(fabio.isBoiola);
        }


        [Test]
        public void FabioVemdeCanidelo()
        {
            Assert.AreEqual("Canidelo, VC", fabio.Location);            
        }

        [Test]
        public void FabioNaoGostadeGajas()
        {

            var fabio = new Fabio();     
       
               Assert.IsTrue(!fabio.gostadegajas());
        }
        [Test]
        public void SeraqueOFabioePaneleiro()
        {
            Assert.IsTrue(fabio.isBoiola);
        }

    }
}
