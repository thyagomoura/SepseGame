using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuMain : MonoBehaviour
{
    public static bool GameIsOption = false;
    public GameObject OptionsMenuUI;
    public GameObject MainMenuUI;
    public AudioSource Musica;
    public GameObject anim1, anim2;
    public GameObject contButton;

    private void Start()
    {
        if (gameObject.activeSelf)
        {
            Musica.volume = 0.5f;
        }
    }

    public void Play()
    {
        //ir pro jogo
        SceneManager.LoadScene("CustomizeNurse");
    }
    public void Quit()
    {
        //sair do jogo
        Debug.Log("Quit");
        Application.Quit();
    }
    public void GoOptionMenu()
    {
        OptionsMenuUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void BackMainMenu()
    {
        OptionsMenuUI.SetActive(false);
        MainMenuUI.SetActive(true);
        //sair do menu options e voltar para o main menu
        //Debug.Log("Voltar");
    }
    public void GoCustomize()
    {
        //ir pra customizacao de personagem
        SceneManager.LoadScene("CustomizeNurse");
    }
}
