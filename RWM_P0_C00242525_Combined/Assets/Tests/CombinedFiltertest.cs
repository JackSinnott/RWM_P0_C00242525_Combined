using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 5, 8, 3, 10, 9 };
            // diff 5,3,5,7,1

            // diff + decr 5,2,5,7,0
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 5, 2, 5, 7, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

