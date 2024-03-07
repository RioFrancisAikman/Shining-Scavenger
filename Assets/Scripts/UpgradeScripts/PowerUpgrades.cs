using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpgrades : MonoBehaviour
{
    public bool powUp1;
    public bool powUp2;

    public PlayerMovement playerMovement;
    public PlayerAttacks playerAttacks;
    public PlayerPoints playerPoints;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerAttacks = FindObjectOfType<PlayerAttacks>();
        playerPoints = FindObjectOfType<PlayerPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if (powUp1 == true)
        {
            playerMovement.moveSpeed += 1.5f;
            playerAttacks.hammerPower += 1f;

            powUp1 = false;
        }

        if (powUp2 == true)
        {
            playerAttacks.energyPower += 1.5f;

            powUp2 = false;
        }
        
    }
}
