using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeProbability : MonoBehaviour
{
    
    public PlayerPoints playerPoints;
    public int digit;
    public bool spawnUpgrade;
    public float upgradeTimer;

    public GameObject powUpButton1;
    public GameObject powUpButton2;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPoints = FindObjectOfType<PlayerPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPoints.upgradeNow == true)
        { 
            spawnUpgrade = true;
        }

        if(spawnUpgrade == true)
        {
            digit = Random.Range(0, 100);
            upgradeTimer = 0;
            
        }

        if(digit <= 50)
        {
            powUpButton1.gameObject.SetActive(true);
            playerPoints.upgradeNow = false;
            spawnUpgrade = false;
        }
        else
        {
            powUpButton2.gameObject.SetActive(true);
            playerPoints.upgradeNow = false;
            spawnUpgrade = false;
        }

        if (spawnUpgrade == false)
        {
            upgradeTimer += Time.deltaTime;
            if(upgradeTimer >= 0.1f)
            {
                powUpButton1.gameObject.SetActive(false);
                powUpButton2.gameObject.SetActive(false);
                
            }
        }
    }
}
