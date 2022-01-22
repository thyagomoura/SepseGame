using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DialogoManager : MonoBehaviour
{
    public GameObject Saudacao, Opcao1, Opcao2, objResposta, buttonContinuar, buttonAvancar, o1txt, o2txt;
    public Text Resposta;

    int currentPosition = 0;
    float Delay = 0.04f;
    private string fullText = "";

    bool r1 = false;
    bool r2 = false;

    public void Resposta1()
    {
        r1 = true;

        Saudacao.SetActive(false);
        Opcao1.SetActive(false);
        Opcao2.SetActive(false);
        objResposta.SetActive(true);
        buttonAvancar.SetActive(false);

        Opcao1.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        o1txt.GetComponent<Text>().color = new Color(1, 1, 1, 0.5f);

        fullText = "Estou sentindo muito cansaço.";

        StartCoroutine(showText());
    }

    public void Resposta2()
    {
        r2 = true;

        Saudacao.SetActive(false);
        Opcao1.SetActive(false);
        Opcao2.SetActive(false);
        objResposta.SetActive(true);
        buttonAvancar.SetActive(false);

        Opcao2.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        o2txt.GetComponent<Text>().color = new Color(1, 1, 1, 0.5f);

        fullText = "Esta noite não dormi direito devido à tosse e falta de ar.";

        StartCoroutine(showText());
    }

    IEnumerator showText()
    {
        while(currentPosition < fullText.Length)
        {
            Resposta.text += fullText[currentPosition++];
            yield return new WaitForSeconds(Delay);
        }

        buttonContinuar.SetActive(true);
    }

    public void Continuar()
    {
        Saudacao.SetActive(true);
        Opcao1.SetActive(true);
        Opcao2.SetActive(true);
        objResposta.SetActive(false);
        buttonContinuar.SetActive(false);
        Resposta.text = "";
        currentPosition = 0;
        if (r1 && r2)
        {
            buttonAvancar.SetActive(true);
        }
    }

    public void changeScene()
    {
        SceneManager.LoadScene("Hospital");
    }
}
