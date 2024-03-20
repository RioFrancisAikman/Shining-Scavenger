using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeProbability : MonoBehaviour
{
    
    public PlayerPoints playerPoints;
    public int digit1;
    public int digit2;
    public bool spawnUpgrade;
    public float upgradeTimer;

    public GameObject powUpButton1;
    public GameObject powUpButton2;
    public GameObject powUpButton3;
    public GameObject powUpButton4;
    public GameObject powUpButton5;
    public GameObject upgradeTitle;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPoints = FindObjectOfType<PlayerPoints>();
        upgradeTimer = 0.5f;
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
            digit1 = Random.Range(0, 150);
            digit2 = Random.Range(0, 100);
            upgradeTimer = 0;
            upgradeTitle.gameObject.SetActive(true);
            
        }

        if(digit1 <= 65)
        {
            powUpButton1.gameObject.SetActive(true);
            playerPoints.upgradeNow = false;
            spawnUpgrade = false;
        }
        if (digit1 <= 135 && digit1 >= 66)
        {
            powUpButton2.gameObject.SetActive(true);
            playerPoints.upgradeNow = false;
            spawnUpgrade = false;
        }
        if (digit1 >= 136)
        {
            powUpButton4.gameObject.SetActive(true);
            playerPoints.upgradeNow = false;
            spawnUpgrade = false;
        }

        if (digit2 <= 90)
        {
            powUpButton3.gameObject.SetActive(true);
            playerPoints.upgradeNow = false;
            spawnUpgrade = false;
        }
        if (digit2 >= 91)
        {
            powUpButton5.gameObject.SetActive(true);
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
                powUpButton3.gameObject.SetActive(false);
                powUpButton4.gameObject.SetActive(false);
                powUpButton5.gameObject.SetActive(false);
                upgradeTitle.gameObject.SetActive(false);
            }
        }
    }
}
