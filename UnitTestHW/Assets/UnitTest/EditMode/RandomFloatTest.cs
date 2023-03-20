using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class RandomFloatTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void RandomFloatSanityTest()
    {
        Assert.Greater(RandomNum.RandomNumBetweenAB(2, 4), 2);
        Assert.Less(RandomNum.RandomNumBetweenAB(2, 4),4);

        Assert.Greater(RandomNum.RandomNumBetweenAB(1.5f, 3.5f), 1.5f);
        Assert.Less(RandomNum.RandomNumBetweenAB(1.5f, 3.5f),3.5f);
    }


}
