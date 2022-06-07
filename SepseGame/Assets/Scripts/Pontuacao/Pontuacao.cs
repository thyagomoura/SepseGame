using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public List<GameObject> Lines;
    public List<Caso> Casos;
    public Caso Caso;
    public Estetica pack;
    public Selecionados Selecionados;
    public Color Acerto, Erro, NaoMarcou;
    public GameObject ptsText;

    void Start()
    {
        Caso = Casos[pack.currentCase - 1];
        Lines[0].GetComponentInChildren<TextMeshProUGUI>().text = Lines[0].GetComponentInChildren<TextMeshProUGUI>().text + Caso.FrequenciaCardiaca;
        Lines[1].GetComponentInChildren<TextMeshProUGUI>().text = Lines[1].GetComponentInChildren<TextMeshProUGUI>().text + Caso.PressaoArterial;
        Lines[2].GetComponentInChildren<TextMeshProUGUI>().text = Lines[2].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Saturacao;
        Lines[3].GetComponentInChildren<TextMeshProUGUI>().text = Lines[3].GetComponentInChildren<TextMeshProUGUI>().text + Caso.FrequenciaRespiratoria;
        Lines[4].GetComponentInChildren<TextMeshProUGUI>().text = Lines[4].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Temperatura;
        Lines[5].GetComponentInChildren<TextMeshProUGUI>().text = Lines[5].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Glicemia;
        Lines[6].GetComponentInChildren<TextMeshProUGUI>().text = Lines[6].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Neurologico;
        Lines[7].GetComponentInChildren<TextMeshProUGUI>().text = Lines[7].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Respiratorio;
        Lines[8].GetComponentInChildren<TextMeshProUGUI>().text = Lines[8].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Cardiocirculatorio;
        Lines[9].GetComponentInChildren<TextMeshProUGUI>().text = Lines[9].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Gastrintestinal;
        Lines[10].GetComponentInChildren<TextMeshProUGUI>().text = Lines[10].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Renal;
        Lines[11].GetComponentInChildren<TextMeshProUGUI>().text = Lines[11].GetComponentInChildren<TextMeshProUGUI>().text + Caso.Laboratorial;

        int i;
        for(i=0; i < Lines.Count; i++)
        {
            if (Caso.indexesCorretos.Contains(i) && Selecionados.Selected.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = Acerto;
                Caso.pontuacao += 50;
            }
            else if (Caso.indexesCorretos.Contains(i) && !Selecionados.Selected.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = NaoMarcou;
                Caso.pontuacao -= 50;
            }
            else if (!Caso.indexesCorretos.Contains(i) && Selecionados.Selected.Contains(i))
            {
                Lines[i].GetComponent<Image>().color = Erro;
                Caso.pontuacao -= 100;
            }
        }

        ptsText.GetComponent<TextMeshProUGUI>().text = ptsText.GetComponent<TextMeshProUGUI>().text + " " + Caso.pontuacao.ToString() + " pintos";
    }
}
