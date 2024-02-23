using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxEnemyHealth;
    public bool isenemySmall;
    public bool isBigEnemy;
    public float hitTimer;

    public PlayerAttacks playerAttacks;
   // public EnemyChase enemyChase;

    //public GameObject enemyMon;

    // Start is called before the first frame update
    void Start()
    {
        if (isenemySmall)
        {
            maxEnemyHealth = 4;
        }

        if (isBigEnemy)
        {
            maxEnemyHealth = 6;
        }

        playerAttacks = FindObjectOfType<PlayerAttacks>();
    }

    // Update is called once per frame
    void Update()
    {
        if (maxEnemyHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (hitTimer <= 1.4f)
        {
            hitTimer += Time.deltaTime; // Timer limit
        }
    }

    void TakeDamage()
    {
        maxEnemyHealth -= playerAttacks.attackPower; // Takes damage based on player attack power
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitBox")
        {
           // enemyChase.enemySpeed = 0;
            
            if (hitTimer <= 1.2f)
            {
                //TakeDamage(0); // Invulnerable to taking damage briefly
            }

            if (hitTimer >= 1.2f)
            {
                TakeDamage(); // Enemy takes damage
                
                Debug.Log("Rawr!");
                hitTimer = 0;
            }   
            
        }
    }
}
