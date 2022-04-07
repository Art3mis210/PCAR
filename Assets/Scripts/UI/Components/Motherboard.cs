using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Motherboard : MonoBehaviour
{
    public enum CPUSlotType
    {
        LGA1151 = 0,
        AM4 = 1,
        TX4 = 2,
        FCLGA2011 = 3,
        PPGA478 = 4,
        LGA3647 = 5
    };
    public CPUSlotType CPUSlot;
    public enum RamSlotType
    {
        DDR4=0,
        DDR3=0
    }
    public RamSlotType RamSlot;
    public float PCISlot;
}
