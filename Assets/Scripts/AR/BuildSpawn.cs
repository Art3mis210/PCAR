using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSpawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public GameObject Temp;
    public SpawnOnSurface spawnOnSurface;
    public void ChangeSpawnPrefab()
    {
        if(spawnOnSurface._spawnedGameObject!=null)
        {
            Temp = spawnOnSurface._spawnedGameObject;
            spawnOnSurface._spawnedGameObject = Instantiate(SpawnPrefab);
            spawnOnSurface._spawnedGameObject.transform.position = Temp.transform.position;
            spawnOnSurface._spawnedGameObject.transform.rotation = Temp.transform.rotation;
            Destroy(Temp);
        }
        else
        {
            spawnOnSurface.objectPrefab = SpawnPrefab;
        }
    }
}
