using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAR : MonoBehaviour
{
    public SpawnOnSurface spawnOnSurface;
    public void DestroySpawnedObject()
    {
        if (spawnOnSurface._spawnedGameObject != null)
        {
            Destroy(spawnOnSurface._spawnedGameObject);
        }
    }
}
