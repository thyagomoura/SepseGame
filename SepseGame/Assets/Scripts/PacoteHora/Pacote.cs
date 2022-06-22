using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pacote : MonoBehaviour
{
    public Estetica pack;

    public Caso Caso;

    public Button avancarButton;

    public List<Caso> Casos;

    public List<Text> opcoes;

    public List<Toggle> toggles;

    public List<PacotaoGridItem> toggleScripts;

    List<int> numerosSorteados = new List<int>();

    int control = 0;

    void Start()
    {
        Caso = Casos[pack.currentCase - 1];

        updateOptions();
    }

    void updateOptions()
    {
        int i;
        int rand;
        for (i=0; i < opcoes.Count; i++)
        {
            do
            {
                rand = Random.Range(0, 6);
            } while(numerosSorteados.Contains(rand));

            numerosSorteados.Add(rand);
            opcoes[rand].text = Caso.condutas[i];
            toggleScripts[rand].condutaIndex = i;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            numerosSorteados.Clear();
            updateOptions();
        }
    }

    public void optionClicked(int idx)
    {
        int retorno = toggleScripts[idx].updt(control + 1);
        switch (retorno)
        {
            case 1:
                Caso.condSelected.Add(toggleScripts[idx].condutaIndex);
                control++;
                break;
            case 2:
                Caso.condSelected.Remove(toggleScripts[idx].condutaIndex);
                control--;
                break;
        }

        if (control == 6)
        {
            avancarButton.interactable = true;
        }
        else
        {
            avancarButton.interactable = false;
        }
    }

    public void resetSelection()
    {
        control = 0;
        Caso.condSelected.Clear();
        int i;
        for(i=0; i < toggleScripts.Count; i++)
        {
            toggleScripts[i].rst();
        }
    }

    public void Avancar()
    {
        SceneManager.LoadScene("Pontuacao");
    }
}
