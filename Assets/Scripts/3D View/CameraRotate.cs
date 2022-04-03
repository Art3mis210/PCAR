using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public void RotateSpawnerY(float Rotation)
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, Rotation > 180 ? Rotation - 360 : Rotation, transform.rotation.eulerAngles.z);
    }
    public void RotateSpawnerX(float Rotation)
    {
        transform.rotation = Quaternion.Euler(Rotation>180?Rotation-360:Rotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
