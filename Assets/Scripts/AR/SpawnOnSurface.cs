using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnOnSurface : MonoBehaviour
{
    public ARRaycastManager RaycastManager;
    public GameObject objectPrefab;

    private GameObject _spawnedGameObject;
    public GameObject reticlePrefab;
    private GameObject reticle;

    // Start is called before the first frame update
    void Start()
    {
        reticle = Instantiate(reticlePrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (_spawnedGameObject == null)
            {
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    List<ARRaycastHit> hits = new List<ARRaycastHit>();
                    RaycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.Planes);
                    if (hits.Count == 1)
                    {
                        _spawnedGameObject = Instantiate(objectPrefab, hits[0].pose.position, hits[0].pose.rotation);
                        Debug.Log("Object Created");
                        reticle.SetActive(false);
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
                    }
                }
            }
        
    }
}