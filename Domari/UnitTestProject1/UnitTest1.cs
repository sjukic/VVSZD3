using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domari;
using System.Collections.Generic;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StudentskiDom studentskiDom = new StudentskiDom(1000000);
            for(int i=0; i<1000000; i++)
            {
                studentskiDom.Studenti.Add(new Student("ime" + i, "password" + i, new LicniPodaci(),null, new Skolovanje()));
            }

            int x = 0;

            try
            {
                studentskiDom.RadSaStudentomTuning3(studentskiDom.Studenti[10000],0);
            }
            catch (DuplicateWaitObjectException e)
            {

            }
            int y = 0;

        }
    }
}
