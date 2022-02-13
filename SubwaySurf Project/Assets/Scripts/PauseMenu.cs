using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool PauseMenuON = false;
    public GameObject pauseMenu;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseMenuON)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        PauseMenuON = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        PauseMenuON = true;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}