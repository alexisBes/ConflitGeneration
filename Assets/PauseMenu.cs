using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseMenuUI;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        GamePaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        GamePaused = true;
        Time.timeScale = 0f;
    }

    public void ReturnToMainMenu()
    {
        PauseMenuUI.SetActive(false);
        GamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
