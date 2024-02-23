using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
   public int attackPower;
   public GameObject MeleeHitBox;
   public GameObject RangedHitBox;
   public float attackTimer;

   public PlayerEnergyObjectPool playerEnergyObjectPool;
   
    // Start is called before the first frame update
    void Start()
    {
        attackPower = 2;
        attackTimer = 1.4f;
    }

    // Update is called once per frame
    void Update()
    {
        HammerAttack();
        EnergyAttack();

        attackTimer += Time.deltaTime;
        if(attackTimer >= 1.0f) // Melee attack Duration
        {
            MeleeHitBox.SetActive(false);
        }
    }

    void HammerAttack()
    {
        if (Input.GetButtonDown("HammerAttack") && attackTimer >= 1.4f)
        {
            MeleeHitBox.SetActive(true); // Activates hit box to deal damage
            Debug.Log("Pow!");
            attackTimer = 0;
        }
    }

    void EnergyAttack()
    {
        if (Input.GetButtonDown("EnergyAttack") && attackTimer >= 1.4f)
        {
            RangedHitBox.SetActive(true); // Activates hit box to deal damage
            Debug.Log("Swoosh!");
            attackTimer = 0;

            GameObject EnergyBlast = playerEnergyObjectPool.GetEnergyBlast();
            EnergyBlast.SetActive(true);
        }
    }
}
