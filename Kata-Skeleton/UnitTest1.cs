using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Kata_Skeleton
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void CharacterStarter1Level()
        //{
        //    Assert.Inconclusive();
        //}

        [TestMethod]
        public void CharacterStarter1000health()
        {
            Characters personaje = new Characters();
            Assert.IsTrue(personaje.Health == 1000);
        }

        [TestMethod]
        public void isAlive()
        {
            Characters personaje = new Characters();
            bool result = personaje.IsAlive();
            Assert.IsTrue(result);
        }





        [TestMethod]
        public void CharacterCanbeHealed()
        {
            Characters personaje = new Characters();
            personaje.Health = 500;
            Assert.IsTrue( personaje.CanBeHealed());

        }
        [TestMethod]
        public void CharacterDealDamage()
        {
            Characters personaje = new Characters();
            Characters rival = new Characters();
            Assert.IsTrue(personaje.DealDamage(rival));
        }
        [TestMethod]
        public void CharacterCantDamageHimself()
        {
            Characters personaje = new Characters();
            
            Assert.IsTrue(personaje.DealDamage(personaje));
        }

        [TestMethod]
        public void CharacterHeal()
        {
            Characters personaje = new Characters();
        
            Assert.AreEqual(50, personaje.Heal(personaje));
        }

        [TestMethod]
        public void CharacterCantHealhHimself()
        {
            //Characters personaje = new Characters();
            //Characters rival = new Characters();
            //Assert.AreEqual(50, personaje.Heal(rival));
        }




    }



}
