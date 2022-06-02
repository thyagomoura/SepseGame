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
    public GameObject NotificacaoButton;
    public int setText;

    List<int> aferidos = new List<int>();

    private void Start()
    {
        
    }

    public void updatePAS()
    {
        texts[0].text = texts[0].text + " " + Caso.PressaoArterial.ToString();
        setText = 0;
        if (!aferidos.Contains(0))
        {
            aferidos.Add(0);
        }
        EnterNotificacao();
    }

    public void updateFC()
    {
        texts[1].text = texts[1].text + " " + Caso.FrequenciaCardiaca.ToString();
        setText = 1;
        if (!aferidos.Contains(1))
        {
            aferidos.Add(1);
        }
        EnterNotificacao();
    }

    public void updateFR()
    {
        texts[2].text = texts[2].text + " " + Caso.FrequenciaRespiratoria.ToString();
        setText = 2;
        if (!aferidos.Contains(2))
        {
            aferidos.Add(2);
        }
        EnterNotificacao();
    }

    public void updateSO()
    {
        texts[3].text = texts[3].text + " " + Caso.Saturacao.ToString();
        setText = 3;
        if (!aferidos.Contains(3))
        {
            aferidos.Add(3);
        }
        EnterNotificacao();
    }

    public void updateTA()
    {
        texts[4].text = texts[4].text + " " + Caso.Temperatura.ToString();
        setText = 4;
        if (!aferidos.Contains(4))
        {
            aferidos.Add(4);
        }
        EnterNotificacao();
    }

    public void updateGC()
    {
        texts[5].text = texts[5].text + " " + Caso.Glicemia.ToString();
        setText = 5;
        if (!aferidos.Contains(5))
        {
            aferidos.Add(5);
        }
        EnterNotificacao();
    }

    public void updateNeuro()
    {
        texts[6].text = texts[6].text + " " + Caso.Neurologico.ToString();
        setText = 6;
        if (!aferidos.Contains(6))
        {
            aferidos.Add(6);
        }
        EnterNotificacao();
    }

    public void updateResp()
    {
        texts[7].text = texts[7].text + " " + Caso.Respiratorio.ToString();
        setText = 7;
        if (!aferidos.Contains(7))
        {
            aferidos.Add(7);
        }
        EnterNotificacao();
    }

    public void updateCardio()
    {
        texts[8].text = texts[8].text + " " + Caso.Cardiocirculatorio.ToString();
        setText = 8;
        if (!aferidos.Contains(8))
        {
            aferidos.Add(8);
        }
        EnterNotificacao();
    }

    public void updateGastro()
    {
        texts[9].text = texts[9].text + " " + Caso.Gastrintestinal.ToString();
        setText = 9;
        if (!aferidos.Contains(9))
        {
            aferidos.Add(9);
        }
        EnterNotificacao();
    }

    public void updateRenal()
    {
        texts[10].text = texts[10].text + " " + Caso.Renal.ToString();
        setText = 10;
        if (!aferidos.Contains(10))
        {
            aferidos.Add(10);
        }
        EnterNotificacao();
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
    public void EnterNotificacao()
    {
        texts[11].text = texts[setText].text;
        NotificacaoButton.SetActive(true);
    }
    public void OutNotificacao()
    {
        NotificacaoButton.SetActive(false);
    }
}
