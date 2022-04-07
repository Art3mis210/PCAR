using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float ResetPoint;
    public float StartPoint;
    public Vector3 MoveSpeed;
    void Update()
    {
        if(transform.localPosition.x<ResetPoint)
        {
            transform.localPosition = new Vector3(StartPoint, transform.localPosition.y, transform.localPosition.z);
        }
        else
        {
            transform.localPosition += MoveSpeed * Time.deltaTime;
        }
    }
}
