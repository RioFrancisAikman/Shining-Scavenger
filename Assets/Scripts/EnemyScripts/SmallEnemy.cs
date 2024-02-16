using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    public int enemyHealth;

    public PlayerAttacks playerAttacks;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 4;

        playerAttacks = FindObjectOfType<PlayerAttacks>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void TakeDamage()
    {
        enemyHealth -= playerAttacks.attackPower; // Takes damage based on player attack power
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitBox")
        {
            TakeDamage();
            Debug.Log("Rawr!");
        }
    }
}
