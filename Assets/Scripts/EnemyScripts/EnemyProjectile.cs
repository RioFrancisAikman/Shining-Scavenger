using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    public EnemyObjectPool enemyObjectPool;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyObjectPool = FindObjectOfType<EnemyObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.position);
        //transform.Translate(Vector3.forward * 1.6f * Time.deltaTime);

        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemyProjectile.SetActive(false);
        }

        if (other.gameObject.tag == "HitBox")
        {
            enemyProjectile.SetActive(false);
        }
    }
}
