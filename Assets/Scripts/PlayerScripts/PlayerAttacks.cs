using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
   public float attackPower;
   public float hammerPower;
   public float energyPower;
   public GameObject MeleeHitBox;
   public GameObject RangedHitBox;
   public float attackTimer;
   public bool hammerNow;
   public bool energyNow;
    public bool enemyHit;

    public PlayerEnergyObjectPool playerEnergyObjectPool;
   
    // Start is called before the first frame update
    void Start()
    {
        hammerPower = 2;
        energyPower = 2;
        attackTimer = 1.4f;
    }

    // Update is called once per frame
    void Update()
    {
        HammerAttack();
        EnergyAttack();
        
        if (hammerNow == true)
        {
            attackPower = hammerPower;
        }
        

        if (energyNow == true)
        {
            attackPower = energyPower;
        }

        attackTimer += Time.deltaTime;
        if(attackTimer >= 1.0f) // Melee attack Duration
        {
            MeleeHitBox.SetActive(false);
            hammerNow = false;
            energyNow = false;
        }
    }

    void HammerAttack()
    {
        if (Input.GetButtonDown("HammerAttack") && attackTimer >= 1.4f)
        {
            MeleeHitBox.SetActive(true); // Activates hit box to deal damage
            Debug.Log("Pow!");
            attackTimer = 0;
            hammerNow = true;
        }
    }

    void EnergyAttack()
    {
        if (Input.GetButtonDown("EnergyAttack") && attackTimer >= 1.4f)
        {
            RangedHitBox.SetActive(true); // Activates hit box to deal damage
            Debug.Log("Swoosh!");
            attackTimer = 0;

            energyNow = true;

            GameObject EnergyBlast = playerEnergyObjectPool.GetEnergyBlast();
            EnergyBlast.SetActive(true);
        }
    }
}
