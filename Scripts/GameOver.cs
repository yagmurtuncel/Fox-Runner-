using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Text pointsText;
    

    // Update is called once per frame
    void ExitButton()
    {
        SceneManager.LoadScene("EndlessRunner1");
    }
}
