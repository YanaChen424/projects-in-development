
using UnityEngine;


[CreateAssetMenu(fileName ="SceneInfo",menuName ="Persistence")]

public class SceneInfo : ScriptableObject
{
    public bool isNextScene = true;

    private void OnEnable()
    {
        isNextScene = true;
    }
}

