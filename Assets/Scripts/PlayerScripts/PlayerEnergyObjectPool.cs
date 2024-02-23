using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergyObjectPool : MonoBehaviour
{
    // Holds reference to EnergyBlast GameObjects in the pool
    public List<GameObject> energyBlast;
    public GameObject energyPrefab;
    // Number of energyBlast to create in pool
    public int numEnergyBlast;

    private void Awake()
    {
        // Instantiate and disable each EnergyBlast GameObject and add it to the pool list
        energyBlast = new List<GameObject>();
        for (int i = 0; i < numEnergyBlast; i++)
        {
            // Instantiate each GameObject using tag
            GameObject blast = Instantiate(energyPrefab);

            // Set the GameObject as inactivve
            blast.SetActive(false);
            // Add EnergyBlast to pool list
            energyBlast.Add(blast);
        }
    }

    // Get EnergyBlast GameObject from pool
    public GameObject GetEnergyBlast()
    {
        foreach (GameObject obj in energyBlast)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }

           
        }

        GameObject newObj = Instantiate(Resources.Load("EnergyBlast"), Vector3.zero, Quaternion.identity) as GameObject;
        newObj.SetActive(false);
        energyBlast.Add(newObj);
        return newObj;
    }

    public void ReturnEnergyBlast(GameObject obj)
    {
        obj.SetActive(false);
    }
}
