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
            List <Student> studentList = new List<Student>(); 
            for(int i=0; i<1000000; i++)
            {
                studentList.Add(new Student("ime" + i, "password" + i, new LicniPodaci(),null, new Skolovanje()));
            }

            int x = 0;

            try
            {
                studentskiDom.RadSaStudentomTuning1(studentList[10000], 0);
                studentskiDom.RadSaStudentomTuning1(studentList[10000], 0);
            }
            catch (DuplicateWaitObjectException e)
            {

            }
            int y = 0;

        }
    }
}
