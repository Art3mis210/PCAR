using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectPrefab;
    public GameObject SpawnedGameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnedGameObject == null)
        {
            SpawnedGameObject = Instantiate(ObjectPrefab,transform);
            SpawnedGameObject.GetComponent<TouchControls>().isArMode = false;

        }
        else
        {

        }
    }
    
}
