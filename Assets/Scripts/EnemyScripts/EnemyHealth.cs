using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxEnemyHealth;
    public bool isSmallEnemy;
    public bool isBigEnemy;
    public float hitTimer;
    public int pointValue;

    public PlayerAttacks playerAttacks;
    public PlayerPoints playerPoints;
    public PointsCounter pointsCounter;
    public EnemyChase enemyChase;
    

    //public GameObject enemyMon;

    // Start is called before the first frame update
    void Start()
    {
        if (isSmallEnemy)
        {
            maxEnemyHealth = 4;
            pointValue = 1;
        }

        if (isBigEnemy)
        {
            maxEnemyHealth = 6;
            pointValue = 2;
        }

        playerAttacks = FindObjectOfType<PlayerAttacks>();
        playerPoints = FindObjectOfType<PlayerPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if (maxEnemyHealth <= 0)
        {
            Destroy(gameObject);

            if (pointValue == 1)
            {
                playerPoints.CollectedPoint(1);
                PointsCounter.instance.IncreasePoints(pointValue);
                Debug.Log("+1");
            }

            if (pointValue == 2)
            {
               playerPoints.CollectedPoint(2);
               PointsCounter.instance.IncreasePoints(pointValue);
               Debug.Log("+2");
            }
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
           enemyChase.enemySpeed = 0;
            
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

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "HitBox")
        {
           enemyChase.enemySpeed = 2;
        }
    }
}
