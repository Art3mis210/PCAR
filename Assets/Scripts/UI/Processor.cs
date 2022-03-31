using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Processor", menuName = "ScriptableObjects/Processor", order = 0)]
public class Processor : ScriptableObject
{
    public string Model;
    public string Slot;
}
