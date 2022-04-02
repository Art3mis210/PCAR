using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAR : MonoBehaviour
{
    public SpawnOnSurface spawnOnSurface;
    public GameObject ARMode;
    public void ChangeARPrefab(GameObject Prefab)
    {
        spawnOnSurface.objectPrefab = Prefab;
        ARMode.SetActive(true);
        gameObject.SetActive(false);
    }
}
