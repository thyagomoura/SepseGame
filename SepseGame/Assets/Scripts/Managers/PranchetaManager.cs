using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PranchetaManager : MonoBehaviour
{
    public Monitorizar Monitorizar;
    public Text[] texts;

    public void updatePAS()
    {
        texts[0].text = texts[0].text + " " + Monitorizar.PressaoArterial.ToString();
    }

    public void updateFC()
    {
        texts[1].text = texts[1].text + " " + Monitorizar.FrequenciaCardiaca.ToString();
    }

    public void updateFR()
    {
        texts[2].text = texts[2].text + " " + Monitorizar.FrequenciaRespiratoria.ToString();
    }

    public void updateSO()
    {
        texts[3].text = texts[3].text + " " + Monitorizar.Saturacao.ToString();
    }

    public void updateTA()
    {
        texts[4].text = texts[4].text + " " + Monitorizar.Temperatura.ToString();
    }

    public void updateGC()
    {
        texts[5].text = texts[5].text + " " + Monitorizar.Glicemia.ToString();
    }

    public void updateDU()
    {
        texts[6].text = texts[6].text + " " + Monitorizar.DebitoUrinario.ToString();
    }
}
