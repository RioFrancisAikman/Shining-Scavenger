using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxEnemyHealth;
    public bool isSmallEnemy;
    public bool isBigEnemy;
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
                ScoreCounter.instance.IncreasePoints(pointValue);
                Debug.Log("+1");
            }

            if (pointValue == 2)
            {
               playerPoints.CollectedPoint(2);
               PointsCounter.instance.IncreasePoints(pointValue);
               ScoreCounter.instance.IncreasePoints(pointValue);
               Debug.Log("+2");
            }
        }

        
    }

    void EnemyTakeDamage()
    {
        maxEnemyHealth -= playerAttacks.attackPower; // Takes damage based on player attack power
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitBox")
        {
           enemyChase.enemySpeed = 0;
           
                EnemyTakeDamage(); // Enemy takes damage
                
                Debug.Log("Rawr!");
                
              
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "HitBox")
        {
          // enemyChase.enemySpeed = 2;
        }
    }
}
