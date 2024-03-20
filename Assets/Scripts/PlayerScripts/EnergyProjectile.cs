using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyProjectile : MonoBehaviour
{
    public PlayerAttacks playerAttacks;
    public GameObject energyProjectile;
    public PlayerEnergyObjectPool playerEnergyObjectPool;

    public bool enemyHit;

    // Start is called before the first frame update
    void Start()
    {
        playerAttacks = FindObjectOfType<PlayerAttacks>();
        playerEnergyObjectPool = FindObjectOfType<PlayerEnergyObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerAttacks.attackTimer >= 0.75f) // Ranged attack Duration
        {
            energyProjectile.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            enemyHit = true;
        }
    }

   
}
