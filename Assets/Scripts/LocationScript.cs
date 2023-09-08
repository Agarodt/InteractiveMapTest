using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationScript : MonoBehaviour
{
    [SerializeField]
    int location;

    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        { 
        InfoScript.instance.locType = location;
        InstantiateDescription.instance.currentNode = location;
        InfoScript.instance.Open();
        InstantiateDescription.instance.ChangeText();
        }
    }
}
