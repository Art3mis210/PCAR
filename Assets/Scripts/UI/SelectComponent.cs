using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectComponent : MonoBehaviour
{
    public GameObject[] PCComponentList;
    public int CurrentSection;
    public Button BuildButton;
    public Button NextButton;
    public GameObject Build;
    public GameObject BuildList;

    private PCComponent Motherboard;
    private PCComponent CPU;
    private PCComponent GPU;
    private PCComponent RAM;
    private PCComponent HDDSSD;
    private PCComponent PowerSupply;
    private PCComponent Cabinet;

    public BuildSpawn MotherboardSpawnAR;
    public BuildSpawn CPUSpawnAR;
    public BuildSpawn GPUSpawnAR;
    public BuildSpawn RAMSpawnAR;
    public BuildSpawn HDDSSDSpawnAR;
    public BuildSpawn PowerSupplySpawnAR;
    public BuildSpawn CabinetSpawnAR;

    public BuildSpawnThreeD MotherboardSpawn;
    public BuildSpawnThreeD CPUSpawn;
    public BuildSpawnThreeD GPUSpawn;
    public BuildSpawnThreeD RAMSpawn;
    public BuildSpawnThreeD HDDSSDSpawn;
    public BuildSpawnThreeD PowerSupplySpawn;
    public BuildSpawnThreeD CabinetSpawn;
    private void OnEnable()
    {
        CurrentSection = 0;
        PCComponentList[0].SetActive(true);
        if (Motherboard != null)
        {
            Motherboard.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            Motherboard = null;
        }
        if(CPU!=null)
        {
            CPU.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            CPU = null;
        }
        if (GPU != null)
        {
            GPU.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            GPU = null;
        }
        if (RAM != null)
        {
            RAM.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            RAM = null;
        }
        if (PowerSupply != null)
        {
            PowerSupply.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            PowerSupply = null;
        }
        if (Cabinet != null)
        {
            Cabinet.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            Cabinet = null;
        }
        for(int i=BuildList.transform.childCount-1 ; i>=0;i--)
        {
            Destroy(BuildList.transform.GetChild(i).gameObject);
        }
        foreach(GameObject go in PCComponentList)
        {
            go.SetActive(false);
        }
        PCComponentList[0].SetActive(true);
        BuildButton.interactable = false;
    }
    public void SelectMotherboard(PCComponent Motherboard)
    {
        if(this.Motherboard!=null)
        {
            this.Motherboard.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.Motherboard = Motherboard;
        this.Motherboard.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        foreach (CPU cpu in PCComponentList[1].GetComponentsInChildren<CPU>(true))
        {
            if (cpu.CPUSlot == Motherboard.GetComponent<Motherboard>().CPUSlot)
                cpu.transform.gameObject.SetActive(true);
            else
                cpu.transform.gameObject.SetActive(false);
        }
        foreach (RAM ram in PCComponentList[2].GetComponentsInChildren<RAM>(true))
        {
            if (ram.RamType== Motherboard.GetComponent<Motherboard>().RamType)
                ram.transform.gameObject.SetActive(true);
            else
                ram.transform.gameObject.SetActive(false);
        }
        if(CPU!=null)
        {
            CPU.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            CPU = null;
        }
        if (GPU != null)
        {
            GPU.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            GPU = null;
        }
        if (RAM != null)
        {
            RAM.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
            RAM = null;
        }
        NextButton.interactable = true;
        //MotherboardList.SetActive(false);
        //CPUList.SetActive(true);
    }
    public void SelectCPU(PCComponent CPU)
    {
        if (this.CPU != null)
        {
            this.CPU.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.CPU = CPU;
        this.CPU.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        // CPUList.SetActive(false);
        //GPUList.SetActive(true);
        NextButton.interactable = true;
    }
    public void SelectGPU(PCComponent GPU)
    {
        if (this.GPU != null)
        {
            this.GPU.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.GPU = GPU;
        this.GPU.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        //GPUList.SetActive(false);
        //RAMList.SetActive(true);
        NextButton.interactable = true;
    }
    public void SelectRAM(PCComponent RAM)
    {
        if (this.RAM != null)
        {
            this.RAM.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.RAM = RAM;
        this.RAM.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        //RAMList.SetActive(false);
        //HDDSSDList.SetActive(true);
        NextButton.interactable = true;
    }
    public void SelectHDDSSD(PCComponent HDDSSD)
    {
        if (this.HDDSSD != null)
        {
            this.HDDSSD.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.HDDSSD = HDDSSD;
        this.HDDSSD.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        //HDDSSDList.SetActive(false);
        //PowerSupplyList.SetActive(true);
        NextButton.interactable = true;
    }
    public void SelectPowerSupply(PCComponent PowerSupply)
    {
        if (this.PowerSupply != null)
        {
            this.PowerSupply.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.PowerSupply = PowerSupply;
        this.PowerSupply.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        //PowerSupplyList.SetActive(false);
        //CabinetList.SetActive(true);
        NextButton.interactable = true;
    }
    public void SelectCabinet(PCComponent Cabinet)
    {
        if (this.Cabinet != null)
        {
            this.Cabinet.GetComponentInChildren<Button>(true).transform.gameObject.SetActive(true);
        }
        this.Cabinet = Cabinet;
        this.Cabinet.GetComponentInChildren<Button>().transform.gameObject.SetActive(false);
        NextButton.interactable = true;
        //Build.SetActive(true);
        //transform.parent.gameObject.SetActive(false);
    }
    public void AssignBuildPrefabs()
    {
        MotherboardSpawnAR.SpawnPrefab = Motherboard.ComponentPrefab;
        MotherboardSpawn.SpawnPrefab = Motherboard.ComponentPrefab;
        Instantiate(Motherboard.gameObject, BuildList.transform);
        CPUSpawnAR.SpawnPrefab = CPU.ComponentPrefab;
        CPUSpawn.SpawnPrefab = CPU.ComponentPrefab;
        Instantiate(CPU.gameObject, BuildList.transform);
        GPUSpawnAR.SpawnPrefab = GPU.ComponentPrefab;
        GPUSpawn.SpawnPrefab = GPU.ComponentPrefab;
        Instantiate(GPU.gameObject, BuildList.transform);
        RAMSpawnAR.SpawnPrefab = RAM.ComponentPrefab;
        RAMSpawn.SpawnPrefab = RAM.ComponentPrefab;
        Instantiate(RAM.gameObject, BuildList.transform);
        HDDSSDSpawnAR.SpawnPrefab = HDDSSD.ComponentPrefab;
        HDDSSDSpawn.SpawnPrefab = HDDSSD.ComponentPrefab;
        Instantiate(HDDSSD.gameObject, BuildList.transform);
        PowerSupplySpawnAR.SpawnPrefab = PowerSupply.ComponentPrefab;
        PowerSupplySpawn.SpawnPrefab = PowerSupply.ComponentPrefab;
        Instantiate(PowerSupply.gameObject, BuildList.transform);
        CabinetSpawnAR.SpawnPrefab = Cabinet.ComponentPrefab;
        CabinetSpawn.SpawnPrefab = Cabinet.ComponentPrefab;
        Instantiate(Cabinet.gameObject, BuildList.transform);

    }
    public void NextSection()
    {
        if(CurrentSection<=PCComponentList.Length-1)
        {
            if (CurrentSection == 0 && Motherboard == null)
            {
                NextButton.interactable = false;
            }
            else if (CurrentSection == 1 && CPU == null)
            {
                NextButton.interactable = false;
            }
            else if (CurrentSection == 2 && GPU == null)
            {
                NextButton.interactable = false;
            }
            else if (CurrentSection == 3 && RAM == null)
            {
                NextButton.interactable = false;
            }
            else if (CurrentSection == 4 && HDDSSD == null)
            {
                NextButton.interactable = false;
            }
            else if (CurrentSection == 5 && PowerSupply == null)
            {;
                NextButton.interactable = false;
            }
            else if (CurrentSection == 6 && Cabinet == null)
            {
                NextButton.interactable = false;
            }
            else if(CurrentSection<6)
            {
                PCComponentList[CurrentSection].SetActive(false);
                CurrentSection += 1;
                PCComponentList[CurrentSection].SetActive(true);
            }
            else
            {
                NextButton.interactable = false;
                BuildButton.interactable = true;
            }
        }
    }
    public void PreviousSection()
    {
        if (CurrentSection > 0)
        {
            PCComponentList[CurrentSection].SetActive(false);
            CurrentSection -= 1;
            PCComponentList[CurrentSection].SetActive(true);
        }
    }

}
