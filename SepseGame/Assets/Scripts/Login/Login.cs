using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public static string nome = "defaultName";
    public static string cpf = "12345678910";
    public GameObject inputFieldNome;
    public GameObject inputFieldCpf;

    public void ReceberNome()
    {
        nome = inputFieldNome.GetComponent<TextMeshProUGUI>().text;
        
    }
    public void ReceberCpf()
    {
        cpf = inputFieldCpf.GetComponent<TextMeshProUGUI>().text;
        
    }
    [System.Obsolete]
    public void ProxScene()
    {
        Application.LoadLevel("MainMenu");
    }
}
