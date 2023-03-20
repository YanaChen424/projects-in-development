using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ArrayTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void ArraySenityTest()
    {
        Assert.AreEqual(4, Array.Index(new int[] {4,3,7,9,2,6}));
    }
    [Test]
    public void ArraySenityTest2()
    {
        Assert.AreEqual(3, Array.Index(new int[] { 4, 3, 7, 1, 2, 6 }));
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ArrayTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
