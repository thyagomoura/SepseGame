using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PranchetaManager : MonoBehaviour
{
    public Monitorizar Monitorizar;
    public Text[] texts;
    public Toggle[] Toggles;
    public Selecionados ArraySelected;
    public Aferidos ArrayAferidos;

    public void updatePAS()
    {
        texts[0].text = texts[0].text + " " + Monitorizar.PressaoArterial.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(0))
        {
            ArrayAferidos.IndexesAferidos.Add(0);
        }
    }

    public void updateFC()
    {
        texts[1].text = texts[1].text + " " + Monitorizar.FrequenciaCardiaca.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(1))
        {
            ArrayAferidos.IndexesAferidos.Add(1);
        }
    }

    public void updateFR()
    {
        texts[2].text = texts[2].text + " " + Monitorizar.FrequenciaRespiratoria.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(2))
        {
            ArrayAferidos.IndexesAferidos.Add(2);
        }
    }

    public void updateSO()
    {
        texts[3].text = texts[3].text + " " + Monitorizar.Saturacao.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(3))
        {
            ArrayAferidos.IndexesAferidos.Add(3);
        }
    }

    public void updateTA()
    {
        texts[4].text = texts[4].text + " " + Monitorizar.Temperatura.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(4))
        {
            ArrayAferidos.IndexesAferidos.Add(4);
        }
    }

    public void updateGC()
    {
        texts[5].text = texts[5].text + " " + Monitorizar.Glicemia.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(5))
        {
            ArrayAferidos.IndexesAferidos.Add(5);
        }
    }

    public void updateDU()
    {
        texts[6].text = texts[6].text + " " + Monitorizar.DebitoUrinario.ToString();
        if (!ArrayAferidos.IndexesAferidos.Contains(6))
        {
            ArrayAferidos.IndexesAferidos.Add(6);
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
}
