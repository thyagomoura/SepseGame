using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class Login : MonoBehaviour
{
    public static string nome = "defaultName";
    public static string cpf = "12345678910";
    public GameObject inputFieldNome;
    public GameObject inputFieldCpf;
    public GameObject PlaceHolderNome;
    public GameObject PlaceHolderCpf;
    public bool permited = false;

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
        if (nome != "defaultName")
        {
            permited = true;
        }
        else
        {
            permited = false;
            PlaceHolderNome.GetComponent<TextMeshProUGUI>().text = "O nome ainda não foi inserido!";
            PlaceHolderNome.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
        if(permited)
        {
            if (cpf != "12345678910")
            {
                permited = true;
            }
            else
            {
                permited = false;
                PlaceHolderCpf.GetComponent<TextMeshProUGUI>().text = "O CPF ainda não foi inserido";
                PlaceHolderCpf.GetComponent<TextMeshProUGUI>().color = Color.red;
            }
        }
        if (permited)
        {
            Application.LoadLevel("TextoInicial");
        } 
    }
}
