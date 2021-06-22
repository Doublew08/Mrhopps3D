using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    private bool GameIsPaused=false;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
           
        }
    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
}
