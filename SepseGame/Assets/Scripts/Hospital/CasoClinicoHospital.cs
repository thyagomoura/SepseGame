using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CasoClinicoHospital : MonoBehaviour
{
    public GameObject CasoClinicoPanel;
    public Caso Caso;
    public Estetica pack;
    public GameObject CasoClinicoText;
    public List<Caso> ArrayCasos;

    public void showCasoClinico()
    {
        Caso = ArrayCasos[pack.currentCase];
        CasoClinicoPanel.SetActive(true);
        CasoClinicoText.GetComponent<TextMeshProUGUI>().text = Caso.historiaClinica;
    }

    public void hideCasoClinico()
    {
        CasoClinicoPanel.SetActive(false);
    }
}
