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

    public static string[] acerto = new string[10];
    public static string[] erro = new string[10];
    public static int count = 0, countError = 0;
    public int acertos;
    public int naoMarcados;
    public int erros;

    void Start()
    {
        Caso = Casos[pack.currentCase - 1];
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

        int i;
        for(i=0; i < Lines.Count; i++)
        {
            if (Caso.indexesCorretos.Contains(i) && Caso.selecionados.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = Acerto;
                acerto[count] = Lines[i].GetComponentInChildren<TextMeshProUGUI>().text;
                count++;
                acertos++;
                Caso.pontuacao += 50;
            }
            else if (Caso.indexesCorretos.Contains(i) && !Caso.selecionados.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = NaoMarcou;
                erro[countError] = Lines[i].GetComponentInChildren<TextMeshProUGUI>().text;
                countError++;
                naoMarcados++;
                Caso.pontuacao -= 25;
            }
            else if (!Caso.indexesCorretos.Contains(i) && Caso.selecionados.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = Erro;
                erro[countError] = Lines[i].GetComponentInChildren<TextMeshProUGUI>().text;
                countError++;
                erros++;
                Caso.pontuacao -= 25;
            }
        }

        ptsText.GetComponent<TextMeshProUGUI>().text = ptsText.GetComponent<TextMeshProUGUI>().text + " " + Caso.pontuacao.ToString() + " pontos";

        

        sliders[0].value = acertos;
        sliders[1].value = naoMarcados;
        sliders[2].value = erros;
    }

    public void transition()
    {
        SceneManager.LoadScene("Transicao");
    }
}
