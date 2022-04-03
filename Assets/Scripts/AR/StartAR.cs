using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAR : MonoBehaviour
{
    public SpawnOnSurface spawnOnSurface;
    public Spawner spawner;
    public GameObject ARMode;
    public GameObject ViewMode;
    public void ChangeARPrefab(GameObject Prefab)
    {
        spawnOnSurface.objectPrefab = Prefab;
        ARMode.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Change3DPrefab(GameObject Prefab)
    {
        spawner.ObjectPrefab = Prefab;
        ViewMode.SetActive(true);
        gameObject.SetActive(false);
    }
}
