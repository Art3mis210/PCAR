using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsManager : MonoBehaviour
{
    private GameObject ActiveComponent;

    public void ChangeActiveComponent(GameObject newActiveComponent)
    {
        if (ActiveComponent != null)
        {
            if (newActiveComponent != ActiveComponent)
            {
                ActiveComponent.SetActive(false);
                ActiveComponent = newActiveComponent;
                ActiveComponent.SetActive(true);
            }
        }
        else
        {
            ActiveComponent = newActiveComponent;
            ActiveComponent.SetActive(true);
        }
    }
}
