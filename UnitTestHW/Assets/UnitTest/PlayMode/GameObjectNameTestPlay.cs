using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameObjectNameTestPlay
{

    [UnityTest]
    public IEnumerator GameObjectNameTestPlayWithEnumeratorPasses()
    {
        GameObject temp = new GameObject("Player", typeof(GameObjectName));
        string existingName = temp.GetComponent<GameObjectName>().GetGameObjectName();
        yield return new WaitForSeconds(0.1f);
        Assert.AreEqual("Player", existingName);
    }
}
