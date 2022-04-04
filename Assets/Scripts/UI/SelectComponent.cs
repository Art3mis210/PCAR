using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectComponent : MonoBehaviour
{
    public GameObject MotherboardList;
    public GameObject CPUList;
    public GameObject GPUList;
    public GameObject RAMList;
    public GameObject HDDSSDList;
    public GameObject PowerSupplyList;
    public GameObject CabinetList;
    public GameObject Build;

    private PCComponent Motherboard;
    private PCComponent CPU;
    private PCComponent GPU;
    private PCComponent RAM;
    private PCComponent HDDSSD;
    private PCComponent PowerSupply;
    private PCComponent Cabinet;

    public BuildSpawn MotherboardSpawn;
    public BuildSpawn CPUSpawn;
    public BuildSpawn GPUSpawn;
    public BuildSpawn RAMSpawn;
    public BuildSpawn HDDSSDSpawn;
    public BuildSpawn PowerSupplySpawn;
    public BuildSpawn CabinetSpawn;

    public void SelectMotherboard(PCComponent Motherboard)
    {
        this.Motherboard = Motherboard;
        foreach(CPU cpu in CPUList.GetComponentsInChildren<CPU>())
        {
            if (cpu.CPUSlot != Motherboard.GetComponent<Motherboard>().CPUSlot)
                cpu.transform.gameObject.SetActive(false);
        }
        foreach (RAM ram in RAMList.GetComponentsInChildren<RAM>())
        {
            if (ram.RamType!= Motherboard.GetComponent<Motherboard>().RamType)
                ram.transform.gameObject.SetActive(false);
        }
        MotherboardList.SetActive(false);
        CPUList.SetActive(true);
    }
    public void SelectCPU(PCComponent CPU)
    {
        this.CPU = CPU;
        CPUList.SetActive(false);
        GPUList.SetActive(true);
    }
    public void SelectGPU(PCComponent GPU)
    {
        this.GPU = GPU;
        GPUList.SetActive(false);
        RAMList.SetActive(true);
    }
    public void SelectRAM(PCComponent RAM)
    {
        this.RAM = RAM;
        RAMList.SetActive(false);
        HDDSSDList.SetActive(true);
    }
    public void SelectHDDSSD(PCComponent HDDSSD)
    {
        this.HDDSSD = HDDSSD;
        HDDSSDList.SetActive(false);
        PowerSupplyList.SetActive(true);
    }
    public void SelectPowerSupply(PCComponent PowerSupply)
    {
        this.PowerSupply = PowerSupply;
        PowerSupplyList.SetActive(false);
        CabinetList.SetActive(true);
    }
    public void SelectCabinet(PCComponent Cabinet)
    {
        this.Cabinet = Cabinet;
        CabinetList.SetActive(true);
        AssignBuildPrefabs();
        Build.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
    void AssignBuildPrefabs()
    {
        MotherboardSpawn.SpawnPrefab = Motherboard.ComponentPrefab;
        CPUSpawn.SpawnPrefab = CPU.ComponentPrefab;
        GPUSpawn.SpawnPrefab = GPU.ComponentPrefab;
        RAMSpawn.SpawnPrefab = RAM.ComponentPrefab;
        HDDSSDSpawn.SpawnPrefab = HDDSSD.ComponentPrefab;
        PowerSupplySpawn.SpawnPrefab = PowerSupply.ComponentPrefab;
        CabinetSpawn.SpawnPrefab = Cabinet.ComponentPrefab;
    }

}
