using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TransicaoManager : MonoBehaviour
{
    public Estetica Estetica;
    public GameObject text;

    void Start()
    {
        Estetica.set = false;
        Estetica.currentCase++;
        text.GetComponent<TextMeshProUGUI>().text = text.GetComponent<TextMeshProUGUI>().text + " " + Estetica.currentCase.ToString();
    }

    public void goNext()
    {
        SceneManager.LoadScene("Dialogo");
    }
}
