using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pontuacao : MonoBehaviour
{
    public List<GameObject> Lines;
    public List<Caso> Casos;
    public Caso Caso;
    public Estetica pack;
    public Color Acerto, Erro, NaoMarcou;
    public GameObject ptsText;
    public List<Slider> sliders;
    public List<GameObject> textsStats;
    public List<TextMeshProUGUI> avisos;
    public GameObject tempoText;

    public static int count = 0, countError = 0;
    float acertos;
    float naoMarcados;
    float erros;

    void Start()
    {
        Caso = Casos[pack.currentCase];
        Lines[0].GetComponentInChildren<TextMeshProUGUI>().text = Lines[0].GetComponentInChildren<TextMeshProUGUI>().text + Caso.FrequenciaCardiaca;
        Lines[1].GetComponentInChildren<TextMeshProUGUI>().text = Lines[1].GetComponentInChildren<TextMeshProUGUI>().text + Caso.PressaoArterial;
        Lines[2].GetComponentInChildren<TextMeshProUGUI>().text = Lines[2].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Saturacao;
        Lines[3].GetComponentInChildren<TextMeshProUGUI>().text = Lines[3].GetComponentInChildren<TextMeshProUGUI>().text + Caso.FrequenciaRespiratoria;
        Lines[4].GetComponentInChildren<TextMeshProUGUI>().text = Lines[4].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Temperatura;
        Lines[5].GetComponentInChildren<TextMeshProUGUI>().text = Lines[5].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Neurologico;
        Lines[6].GetComponentInChildren<TextMeshProUGUI>().text = Lines[6].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Respiratorio;
        Lines[7].GetComponentInChildren<TextMeshProUGUI>().text = Lines[7].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Cardiocirculatorio;
        Lines[8].GetComponentInChildren<TextMeshProUGUI>().text = Lines[8].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Gastrintestinal;
        Lines[9].GetComponentInChildren<TextMeshProUGUI>().text = Lines[9].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Renal;
        Lines[10].GetComponentInChildren<TextMeshProUGUI>().text = Lines[10].GetComponentInChildren<TextMeshProUGUI>().text + Caso.lab1;
        Lines[11].GetComponentInChildren<TextMeshProUGUI>().text = Lines[11].GetComponentInChildren<TextMeshProUGUI>().text + Caso.lab2;
        Lines[12].GetComponentInChildren<TextMeshProUGUI>().text = Lines[12].GetComponentInChildren<TextMeshProUGUI>().text + Caso.lab3;
        Lines[13].GetComponentInChildren<TextMeshProUGUI>().text = Lines[13].GetComponentInChildren<TextMeshProUGUI>().text + Caso.lab4;

        load1();
    }
    void load1()
    {
        for (int i = 0; i < Lines.Count; i++)
        {
            if (Caso.indexesCorretos.Contains(i) && Caso.selecionados.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = Acerto;
                count++;
                acertos++;
                Caso.pontuacao += 10;
            }
            else if (Caso.indexesCorretos.Contains(i) && !Caso.selecionados.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = NaoMarcou;
                countError++;
                naoMarcados++;
                Caso.pontuacao -= 5;
            }
            else if (!Caso.indexesCorretos.Contains(i) && Caso.selecionados.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = Erro;
                countError++;
                erros++;
                Caso.pontuacao -= 5;
            }
        }

        if (Caso.pontuacao < 0)
        {
            Caso.pontuacao = 0;
        }

        ptsText.GetComponent<TextMeshProUGUI>().text = ptsText.GetComponent<TextMeshProUGUI>().text + " " + Caso.pontuacao.ToString() + "/" + (Caso.indexesCorretos.Count * 10 + 110).ToString() + " pontos";

        load2();
    }

    void load2()
    {
        int slot = 0;
        if (!Caso.abriuProtocolo)
        {
            avisos[slot].text = "O Protocolo de Sepse não foi aberto! -10 pontos";
            slot++;
        }
        if (!Caso.chamouEquipe)
        {
            avisos[slot].text = "A Equipe Médica não foi acionada! -10 pontos";
            slot++;
        }
        if (!Caso.apertouBotaoCorreto)
        {
            if (Caso.buttonCorreto == 1)
            {
                avisos[slot].text = "O Protocolo de Sepse deveria ter sido descontinuado! -15 pontos";
                slot++;
            }
            else
            {
                avisos[slot].text = "O Protocolo de Sepse deveria ter sido continuado! -15 pontos";
                slot++;
            }
        }

        load3();
    }

    void load3()
    {
        sliders[0].maxValue = Caso.indexesCorretos.Count;
        sliders[0].value = acertos;
        textsStats[0].GetComponent<Text>().text = Mathf.Floor(acertos / Caso.indexesCorretos.Count * 100).ToString("") + "%";

        sliders[1].maxValue = Caso.indexesCorretos.Count;
        sliders[1].value = naoMarcados;
        textsStats[1].GetComponent<Text>().text = Mathf.Floor(naoMarcados / Caso.indexesCorretos.Count * 100).ToString("") + "%";

        sliders[2].maxValue = Lines.Count;
        sliders[2].value = erros;
        textsStats[2].GetComponent<Text>().text = erros.ToString();

        TimerManager timer = GameObject.Find("Timer").GetComponent<TimerManager>();
        Caso.time = timer.timeLeft - pack.lastTime;

        float minutes = Mathf.FloorToInt(Caso.time / 60);
        float seconds = Mathf.FloorToInt(Caso.time % 60);

        tempoText.GetComponent<TextMeshProUGUI>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void transition()
    {
        SceneManager.LoadScene("Transicao");
    }
}
