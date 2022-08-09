using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text2Handler : MonoBehaviour
{
    int currentPosition;
    string fullText = "Sua tomada de decisão permitirá que você avance no jogo. Utilize o sistema de clicks para ativar os diálogos, as tomadas de decisões e as ações. Condutas corretas permitirão que você acumule pontos, caso contrário perderá pontos. No total há 13 casos clínicos para serem solucionados. No final de cada caso, você terá um feedback de sua performance. Aparecerá uma janela mostrando o seu desempenho. Boa sorte!";
    float Delay = 0.04f;
    public GameObject T2;

    private void OnEnable()
    {
        StartCoroutine(showText());
    }

    IEnumerator showText()
    {
        while (currentPosition < fullText.Length)
        {
            T2.GetComponent<TextMeshProUGUI>().text += fullText[currentPosition++];
            yield return new WaitForSeconds(Delay);
        }
    }
}
