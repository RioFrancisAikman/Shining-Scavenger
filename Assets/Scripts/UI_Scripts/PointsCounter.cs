using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCounter : MonoBehaviour
{
    public static PointsCounter instance;
    public TMP_Text pointsText;
    public PlayerPoints playerPoints;
    public int currentPoints;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       
        pointsText.text = "Points: " + currentPoints.ToString();
        
        currentPoints = playerPoints.upgradePoints;
    }

    public void IncreasePoints(int v)
    {

            currentPoints += v;
            pointsText.text = "Points: " + currentPoints.ToString();
        
    }

    public void DecreasePoints(int v)
    {

        currentPoints -= v;
        pointsText.text = "Points: " + currentPoints.ToString();

    }
}
