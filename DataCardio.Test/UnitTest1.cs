using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDetermined()
        {
            int età = 20;
            double battiti = 120;

            bool risposta = false;

            bool risultato = false;


            risposta = CardioanalisiLibrary.Class1.IsDetermined(età, battiti) ;

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void Bradicardia()
        {

            double battiti = 50;
            string risultato = "Bradicardia";
            string risposta = "";

            risposta = CardioanalisiLibrary.Class1.IsDetermined1(battiti);
            Assert.AreEqual(risposta, risultato);
        }


        [TestMethod]
        public void Tachicardia()
        {

            double battiti = 120;
            string risultato = "Tachicardia";
            string risposta = "";

            risposta = CardioanalisiLibrary.Class1.IsDetermined1(battiti);
            Assert.AreEqual(risposta, risultato);
        }




    }   
 

    
}

