using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnComponent : MonoBehaviour
{
    public GameObject ComponentPrefab;
    private GameObject SpawnedComponent;
    private ARPlaneManager PlaneManager;
    void Start()
    {
        PlaneManager = GetComponent<ARPlaneManager>();
        SpawnedComponent = Instantiate(ComponentPrefab, transform);
    }
    void Update()
    {
        SpawnedComponent.transform.position = PlaneManager.planePrefab.transform.position;
    }
}
