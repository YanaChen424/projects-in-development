using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ChangeActiveTest
{

    [UnityTest]
    public IEnumerator ChangeActiveTestWithEnumeratorPasses()
    {
        GameObject temp = new GameObject();
        temp.AddComponent<Example>();
        temp.SetActive(false);
        temp.GetComponent<Example>().ChangeActive();
        yield return new WaitForEndOfFrame();
        Assert.IsTrue(temp.active);
    }
}
