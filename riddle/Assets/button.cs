using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public bool IsSelected { get; private set; } = false;

    public GameObject player;
    // Start is called before the first frame update
    public void OnSelect(BaseEventData data)
    {
        IsSelected = true;
        player.GetComponent<Player>().answer = gameObject.name;
    }

    public void OnDeselect(BaseEventData data)
    {
        IsSelected = false;
    }
}
