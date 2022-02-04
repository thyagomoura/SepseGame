using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PacoteDe1hora : MonoBehaviour
{
    int freqCard;
    int saturacao;
    int presArterial;
    int freqRespiratorio;
    int tempAxiliar;
    int glicemiaCapilar;
    int debitoUrinario;

    bool check1;

    private void Start()
    {
        RandomNum();

    }

    private void RandomNum()
    {
        //randomizar valores
        freqCard = Random.Range(20, 100);
        saturacao = Random.Range(20, 100);
        presArterial = Random.Range(20, 100);
        freqRespiratorio = Random.Range(20, 100);
        glicemiaCapilar = Random.Range(20, 100);
        tempAxiliar = Random.Range(20, 100);
        debitoUrinario = Random.Range(20, 100);


        //Inserir valores
        GameObject.Find("Freq. Cardiaca").GetComponent<Text>().text = GameObject.Find("Freq. Cardiaca").GetComponent<Text>().text + ": " + freqCard.ToString();

        GameObject.Find("Saturação de Oxigenio").GetComponent<Text>().text = GameObject.Find("Saturação de Oxigenio").GetComponent<Text>().text + ": " + saturacao.ToString();

        GameObject.Find("Pres. Arterial").GetComponent<Text>().text = GameObject.Find("Pres. Arterial").GetComponent<Text>().text + ": " + presArterial.ToString();

        GameObject.Find("Freq. Respiratoria").GetComponent<Text>().text = GameObject.Find("Freq. Respiratoria").GetComponent<Text>().text + ": " + freqRespiratorio.ToString();

        GameObject.Find("Glicemia Capilar").GetComponent<Text>().text = GameObject.Find("Glicemia Capilar").GetComponent<Text>().text + ": " + glicemiaCapilar.ToString();

        GameObject.Find("Temperatura Axiliar").GetComponent<Text>().text = GameObject.Find("Temperatura Axiliar").GetComponent<Text>().text + ": " + tempAxiliar.ToString();

        GameObject.Find("Debito Urinario").GetComponent<Text>().text = GameObject.Find("Debito Urinario").GetComponent<Text>().text + ": " + debitoUrinario.ToString();
    }


    private void CheckBox()
    {

    }

}
