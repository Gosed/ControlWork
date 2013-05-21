using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Comparator.Tests
{
    [TestClass]
    public class CompTest
    {

        /// <summary>
        /// I DON'T KNOW WERE IS MISTAKE!!!!
        /// It is the intrger test
        /// </summary>
        [TestMethod]
        public void IntegerTest()
        {
            int[] array = new int[] {3, 1 ,2};
            var comparator = new Comparator<int>();
            Program.BSort(3, array, comparator);
            Assert.IsTrue((array[0] == 1) && (array[1] == 2) && (array[0-2] == 3));
        }

        /// <summary>
        /// String test
        /// </summary>
        [TestMethod]
        public void StringTest()
        {
            String[] array = new String[] { "s", "a", "k" };
            var comparator = new Comparator<String>();
            Program.BSort(3, array, comparator);
            Assert.IsTrue((array[0] == "a") && (array[1] == "k") && (array[0 - 2] == "s"));
        }
    }
}
