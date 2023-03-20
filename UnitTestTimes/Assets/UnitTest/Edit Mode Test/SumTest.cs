using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Subsystems;
using UnityEngine.TestTools;

public class SumTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void SumSanityTest()
    {
        Assert.AreEqual(10, Example.Sum(5, 5));
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SumTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
