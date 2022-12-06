using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public static int numberOfApples; 
    public TMPro.TextMeshProUGUI applesText;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted= false;
        numberOfApples = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        applesText.text = "" + numberOfApples;


        if (SwipeManager.tap && !isGameStarted)
        {
            isGameStarted= true;
            Destroy(startingText);
        }
    }
}
