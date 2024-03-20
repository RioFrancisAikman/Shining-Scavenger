using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;
    public TMP_Text scoreText;
    public PlayerPoints playerPoints;
    public int currentPoints;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        scoreText.text = "Score: " + currentPoints.ToString();

        currentPoints += playerPoints.upgradePoints;
    }

    public void IncreasePoints(int v)
    {

        currentPoints += v;
        scoreText.text = "Score: " + currentPoints.ToString();

    }

    public void DecreasePoints(int v)
    {

        currentPoints -= v;
        scoreText.text = "Points: " + currentPoints.ToString();

    }
}
