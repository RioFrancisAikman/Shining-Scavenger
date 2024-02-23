using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObjectPool : MonoBehaviour
{
    // Holds reference to EnemyBlast GameObjects in the pool
    public List<GameObject> enemyBlast;
    public GameObject energyPrefab;
    // Number energy to create in pool
    public int numEnergyBlast;

    private void Awake()
    {
        // Instantiate and disable each EnergyBlast GameObject and add it to the pool list
        enemyBlast = new List<GameObject>();
        for (int i = 0; i < numEnergyBlast; i++)
        {
            // Instantiate each GameObject using tag
            GameObject blast = Instantiate(energyPrefab);

            // Set the GameObject as inactivve
            blast.SetActive(false);
            // Add EnemyBlast to pool list
            enemyBlast.Add(blast);
        }
    }

    // Get EnemyBlast GameObject from pool
    public GameObject GetEnemyBlast()
    {
        foreach (GameObject obj in enemyBlast)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }

           
        }

        GameObject newObj = Instantiate(Resources.Load("EnemyBlast"), Vector3.zero, Quaternion.identity) as GameObject;
        newObj.SetActive(false);
        enemyBlast.Add(newObj);
        return newObj;
    }

    public void ReturnEnergyBlast(GameObject obj)
    {
        obj.SetActive(false);
    }
}
