using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopView : MonoBehaviour
{
    public Spawner spawner;
    public void Stop3Dview()
    {
        if (spawner.SpawnedGameObject != null)
        {
            Destroy(spawner.SpawnedGameObject);
        }
    }
}
