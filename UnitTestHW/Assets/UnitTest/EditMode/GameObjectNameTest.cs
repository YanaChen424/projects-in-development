using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameObjectNameTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void GameObjectNameSanityTest()
    {
        GameObject temp = new GameObject("Player",typeof(GameObjectName));
        string existingName = temp.GetComponent<GameObjectName>().GetGameObjectName();

        Assert.AreEqual("Player",existingName);
    }

}
