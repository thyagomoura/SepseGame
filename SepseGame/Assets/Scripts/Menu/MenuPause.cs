using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuPause : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public GameObject PauseIcon;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        PauseIcon.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        PauseIcon.SetActive(false);
        Time.timeScale = 0f;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
