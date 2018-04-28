using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BtnScript : MonoBehaviour
{



    public static bool PauseMenu = false;

    public void StartGameBtn()

    {
        SceneManager.LoadScene(1);

    }

    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ExitGameBtn()

    {
        Application.Quit();
    }

}
