using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int upgradePoints;
    public int upgradeReset;
    public bool upgradeNow;

    public PowUpButton powUpButtonA;

    // Start is called before the first frame update
    void Start()
    {
        upgradeReset = 10;
        powUpButtonA = FindObjectOfType<PowUpButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (upgradeNow == false)
        {
            powUpButtonA.powUpButton.gameObject.SetActive(false);
        }
        else if (upgradeNow == true)
        {
            powUpButtonA.powUpButton.gameObject.SetActive(true);
        }
    }

    public void CollectedPoint(int numberOfPoints)
    {
        upgradePoints += numberOfPoints;
        if (upgradePoints >= 10)
        {
            Debug.Log("UpgradeTime");
            upgradeNow = true;
        }
    }
}
