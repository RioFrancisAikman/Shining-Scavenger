using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public int upgradePoints;
    public int upgradeReset;
    public bool upgradeNow;

    // Start is called before the first frame update
    void Start()
    {
        upgradeReset = 10;
    }

    // Update is called once per frame
    void Update()
    {

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
