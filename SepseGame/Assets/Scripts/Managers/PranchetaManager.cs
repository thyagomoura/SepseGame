using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;
using UnityEngine.SceneManagement;

public class PranchetaManager : MonoBehaviour
{
    public Caso Caso;
    public Caso[] ArrayCasos;
    public Text[] texts;
    public Toggle[] Toggles;
    public Animator content;
    public GameObject NotificacaoButton;
    public GameObject notificationText;
    public Estetica pack;
    public GameObject pranchetaDiag;
    public GameObject diagText;
    public GameObject ExameImagem;
    public GameObject xray;
    public GameObject pranchImg;
    public GameObject pranchTxt;
    public GameObject PopUpVerificamedico;
    public GameObject bsepse1, bsepse2;
    public GameObject exameDesc;
    public GameObject sangue;
    public GameObject s1, s2, s3, s4;
    int chamadaMedico;

    List<int> aferidos = new List<int>();
    string setText;

    private void Start()
    {
        Caso = ArrayCasos[pack.currentCase];
    }

    public void updateFC()
    {
        if (!texts[0].text.Contains(Caso.FrequenciaCardiaca))
        {
            texts[0].text = texts[0].text + " " + Caso.FrequenciaCardiaca;
        }
        setText = Caso.FrequenciaCardiaca;
        if (!aferidos.Contains(0))
        {
            aferidos.Add(0);
        }
        EnterNotificacao();
    }

    public void updatePAS()
    {
        if (!texts[1].text.Contains(Caso.PressaoArterial))
        {
            texts[1].text = texts[1].text + " " + Caso.PressaoArterial;
        }
        setText = Caso.PressaoArterial;
        if (!aferidos.Contains(1))
        {
            aferidos.Add(1);
        }
        EnterNotificacao();
    }

    public void updateSO()
    {
        if (!texts[2].text.Contains(Caso.Saturacao))
        {
            texts[2].text = texts[2].text + " " + Caso.Saturacao;
        }
        setText = Caso.Saturacao;
        if (!aferidos.Contains(2))
        {
            aferidos.Add(2);
        }
        EnterNotificacao();
    }

    public void updateFR()
    {
        if (!texts[3].text.Contains(Caso.FrequenciaRespiratoria))
        {
            texts[3].text = texts[3].text + " " + Caso.FrequenciaRespiratoria;
        }
        setText = Caso.FrequenciaRespiratoria;
        if (!aferidos.Contains(3))
        {
            aferidos.Add(3);
        }
        EnterNotificacao();
    }

    public void updateTA()
    {
        if (!texts[4].text.Contains(Caso.Temperatura))
        {
            texts[4].text = texts[4].text + " " + Caso.Temperatura;
        }
        setText = Caso.Temperatura;
        if (!aferidos.Contains(4))
        {
            aferidos.Add(4);
        }
        EnterNotificacao();
    }

    public void updateNeuro()
    {
        if (!texts[5].text.Contains(Caso.Neurologico))
        {
            texts[5].text = texts[5].text + " " + Caso.Neurologico;
        }
        setText = Caso.Neurologico;
        if (!aferidos.Contains(5))
        {
            aferidos.Add(5);
        }
        EnterNotificacao();
    }

    public void updateResp()
    {
        if (!texts[6].text.Contains(Caso.Respiratorio))
        {
            texts[6].text = texts[6].text + " " + Caso.Respiratorio;
        }
        setText = Caso.Respiratorio;
        if (!aferidos.Contains(6))
        {
            aferidos.Add(6);
        }
        EnterNotificacao();
    }

    public void updateCardio()
    {
        if (!texts[7].text.Contains(Caso.Cardiocirculatorio))
        {
            texts[7].text = texts[7].text + " " + Caso.Cardiocirculatorio;
        }
        setText = Caso.Cardiocirculatorio;
        if (!aferidos.Contains(7))
        {
            aferidos.Add(7);
        }
        EnterNotificacao();
    }

    public void updateGastro()
    {
        if (!texts[8].text.Contains(Caso.Gastrintestinal))
        {
            texts[8].text = texts[8].text + " " + Caso.Gastrintestinal;
        }
        setText = Caso.Gastrintestinal;
        if (!aferidos.Contains(8))
        {
            aferidos.Add(8);
        }
        EnterNotificacao();
    }

    public void updateRenal()
    {
        if (!texts[9].text.Contains(Caso.Renal))
        {
            texts[9].text = texts[9].text + " " + Caso.Renal;
        }
        setText = Caso.Renal;
        if (!aferidos.Contains(9))
        {
            aferidos.Add(9);
        }
        EnterNotificacao();
    }

    public void updateLab()
    {
        if (!texts[10].text.Contains(Caso.lab1))
        {
            texts[10].text = texts[10].text + " " + Caso.lab1;
        }
        if (!texts[11].text.Contains(Caso.lab2))
        {
            texts[11].text = texts[11].text + " " + Caso.lab2;
        }
        if (!texts[12].text.Contains(Caso.lab3))
        {
            texts[12].text = texts[12].text + " " + Caso.lab3;
        }
        if (!texts[13].text.Contains(Caso.lab4))
        {
            texts[13].text = texts[13].text + " " + Caso.lab4;
        }

        if(Caso.lab1 != "não tem")
        {
            if (!aferidos.Contains(10))
            {
                aferidos.Add(10);
            }
            if (!aferidos.Contains(11))
            {
                aferidos.Add(11);
            }
            if (!aferidos.Contains(12))
            {
                aferidos.Add(12);
            }
            if (!aferidos.Contains(13))
            {
                aferidos.Add(13);
            }
        }
        
        if (Caso.lab1 == "não tem")
        {
            setText = Caso.lab1;
            EnterNotificacao();
        }
        else
        {
            s1.GetComponent<TextMeshProUGUI>().text = Caso.lab1;
            s2.GetComponent<TextMeshProUGUI>().text = Caso.lab2;
            s3.GetComponent<TextMeshProUGUI>().text = Caso.lab3;
            s4.GetComponent<TextMeshProUGUI>().text = Caso.lab4;
            sangue.SetActive(true);
        }
    }

    public void UpdateSelected()
    {
        int i;
        for (i = 0; i < Toggles.Length; i++)
        {
            if (Toggles[i].isOn)
            {
                if (!Caso.selecionados.Contains(i))
                {
                    Caso.selecionados.Add(i);
                }
            }
            else
            {
                Caso.selecionados.Remove(i);
            }
        }
        if (Caso.selecionados.Count > 0)
        {
            bsepse1.GetComponent<Button>().interactable = true;
            bsepse2.GetComponent<Button>().interactable = true;
        }
        else
        {
            bsepse1.GetComponent<Button>().interactable = false;
            bsepse2.GetComponent<Button>().interactable = false;
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
        notificationText.GetComponent<TextMeshProUGUI>().text = setText;
        //texts[11].text = texts[setText].text;
        NotificacaoButton.SetActive(true);

    }
    public void OutNotificacao()
    {
        NotificacaoButton.SetActive(false);
    }

    public void showXray()
    {
        if (Caso.Imagem != null)
        {
            xray.GetComponent<Image>().sprite = Caso.Imagem;
            ExameImagem.SetActive(true);
            pranchImg.GetComponent<Image>().sprite = Caso.Imagem;
            pranchTxt.GetComponent<TextMeshProUGUI>().text = Caso.descricaoImagem;
            exameDesc.GetComponent<TextMeshProUGUI>().text = Caso.descricaoImagem;
        }
        else
        {
            setText = "não possui";
            EnterNotificacao();
        }
    }

    public void darDiagnostico()
    {
        pranchetaDiag.SetActive(true);
        if(Caso.buttonCorreto == 0)
        {
            diagText.GetComponent<Text>().text = "SEPSE PROVÁVEL";
        }
        else if(Caso.buttonCorreto == 1)
        {
            diagText.GetComponent<Text>().text = "SEPSE POSSÍVEL";
        }
        else if(Caso.buttonCorreto == 2)
        {
            diagText.GetComponent<Text>().text = "Suspeita de DENGUE";
        }
        else if(Caso.buttonCorreto == 3)
        {
            diagText.GetComponent<Text>().text = "Síndrome GRIPAL";
        }
        else if(Caso.buttonCorreto == 4)
        {
            diagText.GetComponent<Text>().text = "Suspeita de EMBOLIA PULMONAR";
        }
    }

    public void hideDiagnostico()
    {
        pranchetaDiag.SetActive(false);
    }

    public void opcaoUm()
    {
        if(Caso.buttonCorreto == 0)
        {
            Caso.pontuacao += 20;
            Caso.apertouBotaoCorreto = true;
        }
        else if(Caso.buttonCorreto>=1)
        {
            Caso.pontuacao -= 15;
            Caso.apertouBotaoCorreto = false;
        }
        SceneManager.LoadScene("Pacotao");
    }

    public void opcaoDois()
    {
        if (Caso.buttonCorreto >= 1)
        {
            Caso.pontuacao += 20;
            Caso.apertouBotaoCorreto = true;
        }
        else if(Caso.buttonCorreto == 0)
        {
            Caso.pontuacao -= 15;
            Caso.apertouBotaoCorreto = false;
        }
        SceneManager.LoadScene("Pacotao");
    }

    public void VerificarChamadaMedico(int idx)
    {
        if (idx == 0)
        {
            if (Caso.buttonCorreto == 0)
            {
                Caso.abriuProtocolo = true;
                Caso.pontuacao += 15;
            }
            else if (Caso.buttonCorreto >0)
            {
                Caso.pontuacao -= 10;
            }
                
        }
        else if(idx == 1)
        {
            if (Caso.buttonCorreto == 0)
            {
                Caso.abriuProtocolo = false;
                Caso.pontuacao -= 10;
            }
            else if(Caso.buttonCorreto > 0)
            {
                Caso.pontuacao += 10;
            }
            
        }
        PopUpVerificamedico.SetActive(true);
    }

    public void chamarEquipe()
    {
        Caso.pontuacao += 15;
        Caso.chamouEquipe = true;
        PopUpVerificamedico.SetActive(false);
        darDiagnostico();
    }

    public void naoChamarEquipe()
    {
        Caso.pontuacao -= 10;
        Caso.chamouEquipe = false;
        PopUpVerificamedico.SetActive(false);
        darDiagnostico();
    }
}
