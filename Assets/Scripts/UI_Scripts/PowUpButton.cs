using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowUpButton : MonoBehaviour
{
    public Button powUpButton;
    public bool isPowUp1;
    public bool isPowUp2;
    public bool isPowUp3;
    public bool isPowUp4;
    public bool isPowUp5;

    public PlayerPoints playerPoints;
    public PowerUpgrades powerUpgrades;

    // Start is called before the first frame update
    void Start()
    {
        playerPoints = FindObjectOfType<PlayerPoints>();
        powerUpgrades = FindObjectOfType<PowerUpgrades>();
    }

    public void ClickPowUp()
    {
        if(isPowUp1 == true)
        {
           
            powerUpgrades.powUp1 = true;

            playerPoints.upgradePoints -= playerPoints.upgradeReset;
            playerPoints.upgradeNow = false;
            
        }
      
        if(isPowUp2 == true)
        {
            
            powerUpgrades.powUp2 = true;

            playerPoints.upgradePoints -= playerPoints.upgradeReset;
            playerPoints.upgradeNow = false;
            
        }

        if (isPowUp3 == true)
        {

            powerUpgrades.powUp3 = true;

            playerPoints.upgradePoints -= playerPoints.upgradeReset;
            playerPoints.upgradeNow = false;

        }

        if (isPowUp4 == true)
        {

            powerUpgrades.powUp4 = true;

            playerPoints.upgradePoints -= playerPoints.upgradeReset;
            playerPoints.upgradeNow = false;

        }

        if (isPowUp5 == true)
        {

            powerUpgrades.powUp5 = true;

            playerPoints.upgradePoints -= playerPoints.upgradeReset;
            playerPoints.upgradeNow = false;

        }

        if (powUpButton != null)
        {
            powUpButton.gameObject.SetActive(false);
        }
        Time.timeScale = 1;

        PointsCounter.instance.DecreasePoints(playerPoints.upgradeReset);
    }
}
