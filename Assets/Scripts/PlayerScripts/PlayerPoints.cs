using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int upgradePoints;
    public int upgradeReset;
    public bool upgradeNow;

    public GameObject powUpButton1;
    public GameObject powUpButton2;
    public GameObject upgradeTitle;

    // Start is called before the first frame update
    void Start()
    {
        upgradeReset = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (upgradeNow == false)
        {
            powUpButton1.gameObject.SetActive(false);
            powUpButton2.gameObject.SetActive(false);
            upgradeTitle.gameObject.SetActive(false);
        }
        else if (upgradeNow == true)
        {
            powUpButton1.gameObject.SetActive(true);
            powUpButton2.gameObject.SetActive(true);
            upgradeTitle.gameObject.SetActive(true);
        }
    }

    public void CollectedPoint(int numberOfPoints)
    {
        upgradePoints += numberOfPoints;
        if (upgradePoints >= 10)
        {
            Debug.Log("UpgradeTime");
            upgradeNow = true;
            Time.timeScale = 0;
        }
    }
}
