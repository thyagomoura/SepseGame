using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class PranchetaManager : MonoBehaviour
{
    public Caso Caso;
    public Caso[] ArrayCasos;
    public Text[] texts;
    public Toggle[] Toggles;
    public Selecionados ArraySelected;
    public Animator content;

    List<int> aferidos = new List<int>();

    private void Start()
    {
        
    }

    public void updatePAS()
    {
        texts[0].text = texts[0].text + " " + Caso.PressaoArterial.ToString();
        if (!aferidos.Contains(0))
        {
            aferidos.Add(0);
        }
    }

    public void updateFC()
    {
        texts[1].text = texts[1].text + " " + Caso.FrequenciaCardiaca.ToString();
        if (!aferidos.Contains(1))
        {
            aferidos.Add(1);
        }
    }

    public void updateFR()
    {
        texts[2].text = texts[2].text + " " + Caso.FrequenciaRespiratoria.ToString();
        if (!aferidos.Contains(2))
        {
            aferidos.Add(2);
        }
    }

    public void updateSO()
    {
        texts[3].text = texts[3].text + " " + Caso.Saturacao.ToString();
        if (!aferidos.Contains(3))
        {
            aferidos.Add(3);
        }
    }

    public void updateTA()
    {
        texts[4].text = texts[4].text + " " + Caso.Temperatura.ToString();
        if (!aferidos.Contains(4))
        {
            aferidos.Add(4);
        }
    }

    public void updateGC()
    {
        texts[5].text = texts[5].text + " " + Caso.Glicemia.ToString();
        if (!aferidos.Contains(5))
        {
            aferidos.Add(5);
        }
    }

    public void updateDU()
    {
        texts[6].text = texts[6].text + " " + Caso.DebitoUrinario.ToString();
        if (!aferidos.Contains(6))
        {
            aferidos.Add(6);
        }
    }

    public void UpdateSelected()
    {
        int i;
        for (i = 0; i < Toggles.Length; i++)
        {
            if (Toggles[i].isOn)
            {
                if (!ArraySelected.Selected.Contains(i))
                {
                    ArraySelected.Selected.Add(i);
                }
            }
            else
            {
                ArraySelected.Selected.Remove(i);
            }
        }
    }

    public void updatePrancheta()
    {
        int i;
        for (i = 0; i < Toggles.Length; i++)
        {
            if (aferidos.Contains(i))
            {
                Toggles[i].interactable = true;
            }
        }
    }
}
