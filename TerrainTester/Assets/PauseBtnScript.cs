using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBtnScript : MonoBehaviour
{
    public static bool PauseMenu = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (PauseMenu)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu = true;
    }

    public void RestartGameBtn()

    {
        SceneManager.LoadScene(1);
    }

    public void ExitGameBtn()

    {
        Application.Quit();
    }
}
