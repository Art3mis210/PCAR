using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCComponent : MonoBehaviour
{
    public string ComponentName;
    public string ComponentDescription;
    public GameObject ComponentPrefab;

    public Text ComponentNameText;
    public Text ComponentDescriptionText;

    public Image ComponentImage;

    public StartAR startAR;


    void Awake()
    {
        ComponentNameText.text = ComponentName;
        ComponentDescriptionText.text = ComponentDescription;
       // if(ComponentImage!=null && ComponentSprite!=null)
       //     ComponentImage.sprite = ComponentSprite;
    }
    public void ViewInAR()
    {
        startAR.ChangeARPrefab(ComponentPrefab);
    }
    public void ViewIn3D()
    {
        startAR.Change3DPrefab(ComponentPrefab);
    }

}
