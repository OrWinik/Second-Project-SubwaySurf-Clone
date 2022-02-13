using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenu;

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

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "MainPlayer")
        {
            winMenu.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
