using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject smallMon;
    public GameObject largeMon;

    public int enemyDigit;
    public float enemyTimer;

    // Start is called before the first frame update
    void Start()
    {
        enemyTimer = 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer += Time.deltaTime;
        if (enemyTimer >= 3.5f)
        {
            enemyDigit = Random.Range(0, 100);
            enemyTimer = 0;

            if (enemyDigit <= 50)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
                Instantiate(smallMon, randomSpawnPosition, Quaternion.identity);
            }
            if (enemyDigit >= 51)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
                Instantiate(largeMon, randomSpawnPosition, Quaternion.identity);
            }
        }

        

    }
}
