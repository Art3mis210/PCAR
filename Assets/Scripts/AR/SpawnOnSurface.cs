using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnOnSurface : MonoBehaviour
{
    public ARRaycastManager RaycastManager;
    public GameObject objectPrefab;

    public GameObject _spawnedGameObject;
    public GameObject Reticle;
    public Camera ARCamera;
    public ARCameraManager arCameraManager;
    public GameObject ShadowPlane;
    public GameObject DirectionalLight;
    void Update()
    {
            if (_spawnedGameObject == null)
            {
                if (Input.touchCount > 0 /*&& Input.GetTouch(0).phase == TouchPhase.Began*/)
                {
                    List<ARRaycastHit> hits = new List<ARRaycastHit>();
                    RaycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
                    if (hits.Count == 1)
                    {
                        _spawnedGameObject = Instantiate(objectPrefab, hits[0].pose.position, hits[0].pose.rotation);
                        _spawnedGameObject.GetComponent<TouchControls>().ShadowPlane = ShadowPlane;
                        ShadowPlane.transform.position = hits[0].pose.position - Vector3.up;
                        Debug.Log("Object Created");
                        Reticle.SetActive(false);
                    }
                }
            }
            else if (_spawnedGameObject != null)
            {
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    List<ARRaycastHit> hits = new List<ARRaycastHit>();
                    RaycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
                    if (hits.Count == 1)
                    {
                        _spawnedGameObject.transform.position = hits[0].pose.position;
                        ShadowPlane.transform.position= _spawnedGameObject.transform.position- Vector3.up;
                }
                }
                if(Vector3.Angle(ARCamera.transform.position+ARCamera.transform.forward, ARCamera.transform.position-_spawnedGameObject.transform.position)<90)
                {
                    if(!Reticle.activeInHierarchy)
                        Reticle.SetActive(true);
                }
                else
                {
                    if (Reticle.activeInHierarchy)
                        Reticle.SetActive(false);
                }
            }
        
    }
}