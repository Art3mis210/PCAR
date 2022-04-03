using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchComponent : MonoBehaviour
{
    private GameObject ProductPage;
    public Text SearchText;
    bool SearchMode;
    List<PCComponent> DisabledComponent;
    List<PCComponent> EnabledComponent;
    void Start()
    {
        ProductPage = transform.parent.gameObject;
        SearchMode = false;
        DisabledComponent = new List<PCComponent>();
        EnabledComponent = new List<PCComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SearchMode==true)
        {
            if(SearchText.text!="")
            {
                if (DisabledComponent.Count != 0)
                {
                    foreach (PCComponent pcComponent in DisabledComponent)
                    {
                        if (pcComponent.ComponentName.ToLower().Contains(SearchText.text.ToLower()) || pcComponent.ComponentDescription.ToLower().Contains(SearchText.text.ToLower()))
                        {
                            pcComponent.transform.gameObject.SetActive(true);
                            EnabledComponent.Add(pcComponent);
                        }
                    }
                    foreach (PCComponent pcComponent in EnabledComponent)
                    {
                        DisabledComponent.Remove(pcComponent);
                    }
                    EnabledComponent.Clear();
                }
                foreach (PCComponent pcComponent in ProductPage.GetComponentsInChildren<PCComponent>())
                {
                    if(!pcComponent.ComponentName.ToLower().Contains(SearchText.text.ToLower()) && !pcComponent.ComponentDescription.ToLower().Contains(SearchText.text.ToLower()))
                    {
                        pcComponent.transform.gameObject.SetActive(false);
                        DisabledComponent.Add(pcComponent);
                    }
                }
                
            }
            else
            {
                if (DisabledComponent.Count != 0)
                {
                    foreach (PCComponent pcComponent in DisabledComponent)
                    {
                        pcComponent.transform.gameObject.SetActive(true);
                        EnabledComponent.Add(pcComponent);
                    }
                    foreach (PCComponent pcComponent in EnabledComponent)
                    {
                        DisabledComponent.Remove(pcComponent);
                    }
                    EnabledComponent.Clear();
                }
            }
        }
    }
    public void ToggleSearchMode()
    {
        SearchMode = !SearchMode;
    }
}
