using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text1Handler : MonoBehaviour
{
    int currentPosition;
    string fullText = "Você será o (a) enfermeiro (a) que está de plantão na unidade de emergência e deverá avaliar cada paciente admitido. O desafio de hoje é reconhecer" +
        " os casos confirmados ou suspeitos de sepse e  com base na presença de disfunção orgânica ou critérios de síndrome de resposta inflamatória sistêmica (SRIS) deverá " +
        "tomar decisões acerca da abertura  ou não do protocolo de sepse, chamar ou não a equipe médica, iniciar ou não o pacote de primeira hora para o tratamento de casos" +
        " suspeitos, priorizar as condutas de enfermagem necessárias para cada caso clínico.";

    float Delay = 0.04f;
    public GameObject T1;

    private void OnEnable()
    {
        StartCoroutine(showText());
    }

    IEnumerator showText()
    {
        while (currentPosition < fullText.Length)
        {
            T1.GetComponent<TextMeshProUGUI>().text += fullText[currentPosition++];
            yield return new WaitForSeconds(Delay);
        }
    }
}
