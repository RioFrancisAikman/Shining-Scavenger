using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public float hitTimer;

    public GameFinishedScript gameFinishedScript;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 10;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hitTimer <= 2.5f)
        {
            hitTimer += Time.deltaTime; // Timer limit
        }

        if (currentHealth > 0)
       {
            gameFinishedScript.gameOverNow = false;
       }
       else if (currentHealth <= 0)
       {
            
            gameFinishedScript.gameOverNow = true;
            Debug.Log("Game Over");
            Time.timeScale = 0;
       }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
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
                //healthBar.SetHealth(currentHealth);
                Debug.Log("Ouch!");
                hitTimer = 0;
            }   
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //myAnimator.SetBool("Attacked", true);

            if (hitTimer <= 2.5f)
            {
                TakeDamage(0); // Invulnerable to taking damage briefly
            }

            if (hitTimer >= 2.5f)
            {
                TakeDamage(1); // Player takes damage
                //healthBar.SetHealth(currentHealth);
                Debug.Log("Ouch!");
                hitTimer = 0;
            }   
        }
    }
}
