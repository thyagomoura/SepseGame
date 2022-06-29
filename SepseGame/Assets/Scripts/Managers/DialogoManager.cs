using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class DialogoManager : MonoBehaviour
{
    public GameObject Opcao1, Opcao2, objResposta, buttonContinuar, buttonAvancar, o1txt, o2txt, Resposta, HC, CasoClinico, Opcoes, contCC;
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
        Caso = ArrayCasos[pack.currentCase];

        HC.GetComponent<TextMeshProUGUI>().text = Caso.historiaClinica;
    }

    public void Resposta1()
    {
        r1 = true;

        Opcao1.SetActive(false);
        Opcao2.SetActive(false);
        buttonAvancar.SetActive(false);

        Resposta.GetComponent<TextMeshProUGUI>().text = "";

        Opcao1.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        o1txt.GetComponent<Text>().color = new Color(1, 1, 1, 0.5f);

        fullText = Caso.dialogo1;

        StartCoroutine(showText());
    }

    public void Resposta2()
    {
        r2 = true;

        Opcao1.SetActive(false);
        Opcao2.SetActive(false);
        buttonAvancar.SetActive(false);

        Resposta.GetComponent<TextMeshProUGUI>().text = "";

        Opcao2.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        o2txt.GetComponent<Text>().color = new Color(1, 1, 1, 0.5f);

        fullText = Caso.dialogo2;

        StartCoroutine(showText());
    }

    IEnumerator showText()
    {
        while(currentPosition < fullText.Length)
        {
            Resposta.GetComponent<TextMeshProUGUI>().text += fullText[currentPosition++];
            yield return new WaitForSeconds(Delay);
        }

        buttonContinuar.SetActive(true);
    }

    public void Continuar()
    {
        Opcao1.SetActive(true);
        Opcao2.SetActive(true);
        buttonContinuar.SetActive(false);
        Resposta.GetComponent<TextMeshProUGUI>().text = "...";
        currentPosition = 0;
        if (r1 && r2)
        {
            buttonAvancar.SetActive(true);
        }
    }

    public void fecharHC()
    {
        CasoClinico.SetActive(false);
        contCC.SetActive(false);
        Opcoes.SetActive(true);
    }

    public void changeScene()
    {
        SceneManager.LoadScene("Hospital");
    }
}
