using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public GameObject player;
    public float enemySpeed;
    public bool isHeavy;

    // Start is called before the first frame update
    void Start()
    {

        if (isHeavy == true)
        {
            enemySpeed = 1f;
        }

        if (isHeavy == false)
        {
            enemySpeed = 2.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
    }
}
