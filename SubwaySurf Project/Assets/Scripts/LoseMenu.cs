using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject loseMenu;

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;

    }

    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1f;

    }
}
