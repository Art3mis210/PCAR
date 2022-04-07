using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSpawnThreeD : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public Spawner spawner;
    public GameObject Temp;
    public void ChangeSpawnPrefab()
    {
        if (spawner.SpawnedGameObject != null)
        {
            Temp = spawner.SpawnedGameObject;
            spawner.SpawnedGameObject = Instantiate(SpawnPrefab);
            spawner.SpawnedGameObject.transform.position = Temp.transform.position;
            spawner.SpawnedGameObject.transform.rotation = Temp.transform.rotation;
            Destroy(Temp);
        }
        else
        {
            spawner.ObjectPrefab = SpawnPrefab;
        }
    }
}
