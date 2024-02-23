using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeEnemyAttack : MonoBehaviour
{
    public GameObject player;
    public float shootTimer;

    public Transform enemySpawnPoint;
    public GameObject myEnemyObjectToSpawn;
    public EnemyObjectPool enemyObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        enemyObjectPool = FindObjectOfType<EnemyObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);

        shootTimer += Time.deltaTime;

        if (shootTimer >= 8.0f)
        {
           // GameObject EnemyProjectile = Instantiate(myEnemyObjectToSpawn, enemySpawnPoint.position, Quaternion.identity) as GameObject;
          // GameObject EnergyBlast = enemyObjectPool.GetEnemyBlast();
            Debug.Log("Blaarg!");
          //  myEnemyObjectToSpawn.SetActive(true);
          shootTimer = 0;
            
        }
        
        

    }
}
