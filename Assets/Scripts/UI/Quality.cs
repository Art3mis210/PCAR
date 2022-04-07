using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quality : MonoBehaviour
{
    public GameObject OnButton;
    public GameObject OffButton;
    public void TurnOn()
    {
        QualitySettings.SetQualityLevel(6);
        OffButton.SetActive(false);
        OnButton.SetActive(true);
    }
    public void TurnOff()
    {
        QualitySettings.SetQualityLevel(3);
        OffButton.SetActive(true);
        OnButton.SetActive(false);
    }
}
