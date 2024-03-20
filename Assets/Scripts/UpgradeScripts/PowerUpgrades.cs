using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpgrades : MonoBehaviour
{
    public bool powUp1;
    public bool powUp2;
    public bool powUp3;
    public bool powUp4;
    public bool powUp5;

    public PlayerMovement playerMovement;
    public PlayerAttacks playerAttacks;
    public PlayerHealth playerHealth;
    public PlayerPoints playerPoints;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerAttacks = FindObjectOfType<PlayerAttacks>();
        playerHealth = FindObjectOfType<PlayerHealth>();
        playerPoints = FindObjectOfType<PlayerPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if (powUp1 == true)
        {
            playerMovement.moveSpeed += 1.5f;
            playerAttacks.hammerPower += 1f;

            powUp1 = false;
        }

        if (powUp2 == true)
        {
            playerAttacks.hammerPower += 1f;

            if (playerHealth.maxHealth <= 11)
            {
                playerHealth.maxHealth += 2; // Boost max health
                healthBar.SetMaxHealth(playerHealth.maxHealth);
            }
            if (playerHealth.maxHealth >= 12)
            {
                playerHealth.currentHealth += 2; // Boost current health when max is 12
                healthBar.SetHealth(playerHealth.currentHealth);
                HealthCounter.instance.IncreaseHealth(playerHealth.currentHealth);
            }

            healthBar.SetHealth(playerHealth.currentHealth);

            powUp2 = false;
        }

        if (powUp3 == true)
        {
            if (playerHealth.maxHealth <= 11)
            {
                playerHealth.maxHealth += 3; // Boost max health
                healthBar.SetMaxHealth(playerHealth.maxHealth);
            }
            if (playerHealth.maxHealth >= 12)
            {
                playerHealth.currentHealth += 3; // Boost current health when max is 12
                healthBar.SetHealth(playerHealth.currentHealth);
                HealthCounter.instance.IncreaseHealth(playerHealth.currentHealth);
            }
            healthBar.SetHealth(playerHealth.currentHealth);

            powUp3 = false;
        }

        if (powUp4 == true)
        {
            playerAttacks.energyPower += 1f;
            playerMovement.moveSpeed += 1f;
            playerHealth.currentHealth += 1;

            healthBar.SetHealth(playerHealth.currentHealth);
            HealthCounter.instance.IncreaseHealth(playerHealth.currentHealth);

            powUp4 = false;
        }

        if (powUp5 == true)
        {
            playerHealth.regenHealth = true;

        }

        if (playerHealth.currentHealth >= playerHealth.maxHealth)
        {
            playerHealth.currentHealth = playerHealth.maxHealth; // current health won't exceed max health
        }

        if (playerMovement.moveSpeed >= 9)
        {
            playerMovement.moveSpeed = 9; // speed won't go over 9
        }

        if (playerAttacks.hammerPower >= 6)
        {
            playerAttacks.hammerPower = 6; // hammer power won't go over 6
        }
        if (playerAttacks.energyPower >= 5)
        {
            playerAttacks.energyPower = 5; // enrgy power won't go over 5
        }

        if (playerHealth.regenHealth == true && playerAttacks.energyNow == true) //&& energyProjectile.enemyHit == true)
        {
            playerHealth.currentHealth += playerAttacks.energyPower * 0.5f; // boost health based on half of attack power
            playerAttacks.energyNow = false;
            //energyProjectile.enemyHit = false;
        }

    }
}
