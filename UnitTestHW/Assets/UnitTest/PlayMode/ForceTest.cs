using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ForceTest
{

    [UnityTest]
    public IEnumerator ForceTestWithEnumeratorPasses()
    {
        GameObject temp = new GameObject();
        temp.AddComponent<Rigidbody>();
        temp.AddComponent<Force>().AddForce();
        yield return new WaitForSeconds(0.1f);
        Assert.AreNotEqual(new Vector3(0,0,0), temp.transform.position);
    }
}
