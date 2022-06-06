using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DialogoManager : MonoBehaviour
{
    public GameObject Saudacao, Opcao1, Opcao2, objResposta, buttonContinuar, buttonAvancar, o1txt, o2txt;
    public Text Resposta;
    public PacienteManager paciente;
    public Caso Caso;
    public Estetica pack;
    public List<Caso> ArrayCasos;

    int currentPosition = 0;
    float Delay = 0.04f;
    private string fullText = "";

    bool r1 = false;
    bool r2 = false;

    private void Start()
    {
        Caso = ArrayCasos[pack.currentCase - 1];
    }

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

        fullText = Caso.dialogo1;

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

        fullText = Caso.dialogo2;

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
