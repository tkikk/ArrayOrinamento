using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdinamentoArray;
using OrdinamentoLibrary;

namespace OrdinamentoLibrary.Test
{
    [TestClass]
    public class VettoreTest
    {
        [TestMethod]
        public void ArrayOrdinamento()
        {
            int[] v1 = new int[] { 11, 22, 13, 4 };
            int[] v2 = new int[] {4, 11,13, 22 };
            int[] vettoreOrdinato = Vettore.Ordina(v1);
            CollectionAssert.AreEqual(v2, vettoreOrdinato);
        }
    }

    
    }

