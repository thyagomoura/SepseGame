using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public GameObject Escolhas;
    public GameObject PauseIcon;
    public Button[] buttonsEscolhas;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        PauseIcon.SetActive(true);
        PauseMenuUI.SetActive(false);
        Escolhas.SetActive(true);
        buttonsEscolhas[0].interactable = !buttonsEscolhas[0].interactable;
        buttonsEscolhas[1].interactable = !buttonsEscolhas[1].interactable;
        buttonsEscolhas[2].interactable = !buttonsEscolhas[2].interactable;
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        PauseIcon.SetActive(false);
        Escolhas.SetActive(false);
        buttonsEscolhas[0].interactable = !buttonsEscolhas[0].interactable;
        buttonsEscolhas[1].interactable = !buttonsEscolhas[1].interactable;
        buttonsEscolhas[2].interactable = !buttonsEscolhas[2].interactable;
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
