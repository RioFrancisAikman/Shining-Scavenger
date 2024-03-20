using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float hitTimer;
    public bool regenHealth;

    public HealthBar healthBar;
    public GameFinishedScript gameFinishedScript;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 6;
        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
        HealthCounter.instance.IncreaseHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hitTimer <= 2.5f)
        {
            hitTimer += Time.deltaTime; // Timer limit
        }

        if (currentHealth >= 1)
       {
            gameFinishedScript.gameOverNow = false;
           // Time.timeScale = 1;
        }
       else if (currentHealth <= 0)
       {
            
            gameFinishedScript.gameOverNow = true;
            Debug.Log("Game Over");
            Time.timeScale = 0;
       }

        if (maxHealth >= 12)
        {
            maxHealth = 12;
        }

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth; // current health won't exceed max health
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthCounter.instance.DecreaseHealth(damage);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //myAnimator.SetBool("Attacked", true);

            if (hitTimer <= 2.5f)
            {
                TakeDamage(0); // Invulnerable to taking damage briefly
            }

            if (hitTimer >= 2.5f)
            {
                TakeDamage(1); // Player takes damage
                healthBar.SetHealth(currentHealth);
                Debug.Log("Ouch!");
                hitTimer = 0;
            }   
        }
    }

    
}
