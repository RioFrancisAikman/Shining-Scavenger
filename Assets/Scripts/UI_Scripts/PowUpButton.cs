using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowUpButton : MonoBehaviour
{
    public Button powUpButton;
    public bool isPowUp1;
    public bool isPowUp2;

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
            if (playerPoints.upgradeNow == true)
            {
                powerUpgrades.powUp1 = true;

                playerPoints.upgradePoints -= playerPoints.upgradeReset;
                playerPoints.upgradeNow = false;
            }
        }
      
        if(isPowUp2 == true)
        {
            if (playerPoints.upgradeNow == true)
            {
                powerUpgrades.powUp2 = true;

                playerPoints.upgradePoints -= playerPoints.upgradeReset;
                playerPoints.upgradeNow = false;
            }
        }
      
        if (powUpButton != null)
        {
            powUpButton.gameObject.SetActive(false);
        }
        Time.timeScale = 1;
    }
}
