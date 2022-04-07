using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentsManager : MonoBehaviour
{
    private GameObject ActiveComponent;
    public Text TitleBar;
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
    public void ChangeTitle(string Title)
    {
        TitleBar.text = Title;
    }
}
