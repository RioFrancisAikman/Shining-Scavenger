using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishedScript : MonoBehaviour
{
    public GameObject gameFinImage;
    public GameObject gameFinText;
    public GameObject totalScore;
    public GameObject restartButton;
    public GameObject exitGameButton;
    public GameObject pointsText;
    // public GameObject healthBar;

    public bool gameOverNow;

    public PlayerPoints playerPoints;


    // Start is called before the first frame update
    void Start()
    {
        gameFinImage.gameObject.SetActive(false);
        gameFinText.gameObject.SetActive(false);
        totalScore.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        exitGameButton.gameObject.SetActive(false);

        pointsText.gameObject.SetActive(true);
        //healthBar.gameObject.SetActive(true);

        playerPoints = FindObjectOfType<PlayerPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOverNow == true)
        {
            gameFinImage.gameObject.SetActive(true);
            gameFinText.gameObject.SetActive(true);
            totalScore.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            exitGameButton.gameObject.SetActive(true);

            pointsText.gameObject.SetActive(false);
            //healthBar.gameObject.SetActive(false);

            Time.timeScale = 0;
        }

        if(playerPoints.upgradeNow == true && gameOverNow == false)
        {
            Time.timeScale = 0;
        }
        else if(gameOverNow == false)
        {
            Time.timeScale = 1;
        }
    }
}
