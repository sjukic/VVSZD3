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
            Student student = new Student("hrvo", "hrvic123", new LicniPodaci(), null, new Skolovanje());
            StudentskiDom studentskiDom = new StudentskiDom(100);
            for(int i=0; i<10; i++)
            {
                studentskiDom.Sobe.Add(new Soba(i, 20));
            }
            studentskiDom.UpisUDom(student, 20, false);
            Assert.AreEqual(studentskiDom.Sobe[100].DaLiJeStanar(student),true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Student student = new Student("hrvo", "hrvic123", new LicniPodaci(), null, new Skolovanje());
            Student student1 = new Student("sadik", "sadik123", new LicniPodaci(), null, new Skolovanje());
            Student student2 = new Student("sanjin", "sanjin123", new LicniPodaci(), null, new Skolovanje());
            StudentskiDom studentskiDom = new StudentskiDom(0);
            for (int i = 0; i < 2; i++)
            {
                studentskiDom.Sobe.Add(new Soba(i, 20));
            }
            studentskiDom.UpisUDom(student, 2, true);
            studentskiDom.UpisUDom(student1, 2, true);
            studentskiDom.UpisUDom(student2, 2, true);
            Assert.AreEqual(studentskiDom.Sobe[0].Stanari.Count, 3);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPrviIzuzetak()
        {
            Student student = new Student("hrvo", "hrvic123", new LicniPodaci(), null, new Skolovanje());
            StudentskiDom studentskiDom = new StudentskiDom(100);
            for (int i = 0; i < 10; i++)
            {
                studentskiDom.Sobe.Add(new Soba(i + 5, 20));
            }
            studentskiDom.UpisUDom(student, 50, false);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestDrugiIzuzetak()
        {
            Student student = new Student("hrvo", "hrvic123", new LicniPodaci(), null, new Skolovanje());
            Student student1 = new Student("sadik", "sadik123", new LicniPodaci(), null, new Skolovanje());
            Student student2 = new Student("sanjin", "sanjin123", new LicniPodaci(), null, new Skolovanje());
            StudentskiDom studentskiDom = new StudentskiDom(1);
            studentskiDom.UpisUDom(student, 2, true);
            studentskiDom.UpisUDom(student1, 2, true);
            studentskiDom.UpisUDom(student2, 2, true);
        }

    }
}
