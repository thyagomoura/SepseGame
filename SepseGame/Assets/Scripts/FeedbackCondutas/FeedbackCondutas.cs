using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class FeedbackCondutas : MonoBehaviour
{
    public List<GameObject> txtCorretas;
    public List<GameObject> txtMarcadas;

    public List<Caso> Casos;
    public Caso Caso;
    public Estetica pack;

    public Color Acerto, Erro;

    void Start()
    {
        Caso = Casos[pack.currentCase];

        for (int i=0; i < txtCorretas.Count; i++)
        {
            txtCorretas[i].GetComponentInChildren<TextMeshProUGUI>().text = Caso.condutas[i];
            txtMarcadas[i].GetComponentInChildren<TextMeshProUGUI>().text = Caso.condutas[Caso.condSelected[i]];

            if (Caso.condutas[i] == Caso.condutas[Caso.condSelected[i]])
            {
                txtMarcadas[i].GetComponent<Image>().color = Acerto;
                Caso.pontuacao += 10;
            }
            else
            {
                txtMarcadas[i].GetComponent<Image>().color = Erro;
                Caso.pontuacao -= 5;
            }
        }
    }

    public void goNext()
    {
        SceneManager.LoadScene("Pontuacao");
    }
}
