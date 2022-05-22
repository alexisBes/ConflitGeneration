using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject game;
    public void TryAgain()
    {
        game.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Debug.Log("Quit App");
        Application.Quit();
    }

    public void Win()
    {
        Debug.Log("New level will be added later");
    }
}
