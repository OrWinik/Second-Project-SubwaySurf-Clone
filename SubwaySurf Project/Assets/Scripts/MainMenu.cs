using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI dimondsText;
    public int overAllCoins;

    public void Awake()
    {
        overAllCoins = PlayerPrefs.GetInt("Dimonds");
        dimondsText.text = overAllCoins.ToString();
    }

    public void Start()
    {
        FindObjectOfType<AudioManager>().play("GameMusic");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
