using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    public GameObject EnableObject;
    public GameObject DisableObject;
    public void EnableDisableObject()
    {
        EnableObject.SetActive(!EnableObject.activeInHierarchy);
        if(DisableObject!=null)
            DisableObject.SetActive(!EnableObject.activeInHierarchy);
    }
}
