using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{

    [UnityTest]
    public IEnumerator MoveToWithEnumeratorPasses()
    {
        GameObject temp = new GameObject();
        temp.AddComponent<Example>().MoveTo(new Vector3(2, 3, 4));
        yield return new WaitForSeconds(0.1f);
        Assert.AreEqual(new Vector3(2, 3, 4), temp.transform.position);
    }
}
