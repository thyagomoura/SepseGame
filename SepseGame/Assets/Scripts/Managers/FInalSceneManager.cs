using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class FInalSceneManager : MonoBehaviour
{
    public GameObject ptsTxt;
    public List<Caso> Casos;
    int totalPontos;
    public TimerManager timer;

    private void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<TimerManager>();

        totalPontos = timer.totalPoints;

        ptsTxt.GetComponent<TextMeshProUGUI>().text = "Você marcou <b>" + totalPontos.ToString() + "</b> pontos de <b>1940</b> pontos.";
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
