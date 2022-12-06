using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
   
{

    public void ReplayGame()
    {
        SceneManager.LoadScene("EndlessRunner1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
