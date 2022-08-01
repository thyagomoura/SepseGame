using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class FInalSceneManager : MonoBehaviour
{
    public GameObject ptsTxt;
    public List<Caso> Casos;
    int totalPontos;

    private void Start()
    {
        
        /*int i;
        for (i=0; i < Casos.Count; i++)
        {
            totalPontos += Casos[i].pontuacao;
        }

        ptsTxt.GetComponent<TextMeshProUGUI>().text = ptsTxt.GetComponent<TextMeshProUGUI>().text + totalPontos.ToString() + " pontos";*/
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(45);
    }

    public void fechar()
    {
        StartCoroutine(Example());
        fechando();
    }
    public void fechando()
    {
        Application.Quit();
    }
}
