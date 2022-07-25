using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TransicaoManager : MonoBehaviour
{
    public Estetica Estetica;
    public EsteticaNurse EsteticaNurse;
    public GameObject text;

    void Start()
    {
        Estetica.set = false;
        Debug.Log(EsteticaNurse.set);
        Estetica.currentCase++;
        if (Estetica.currentCase > 12)
        {
            SceneManager.LoadScene("FinalScene");
        }

        text.GetComponent<TextMeshProUGUI>().text = "CASO " + (Estetica.currentCase + 1).ToString();
    }

    public void goNext()
    {
        SceneManager.LoadScene("Dialogo");
    }
}
