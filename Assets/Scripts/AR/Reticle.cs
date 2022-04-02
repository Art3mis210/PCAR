using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Reticle : MonoBehaviour
{
    public GameObject ReticleSprite;
    private ARRaycastManager RaycastManager;
    private void Start()
    {
        RaycastManager = GetComponent<ARRaycastManager>();
    }
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        RaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
        if (ReticleSprite.activeInHierarchy)
        {
            ReticleSprite.transform.position = hits[0].pose.position;
            ReticleSprite.transform.rotation = hits[0].pose.rotation;
        }
    }
}
