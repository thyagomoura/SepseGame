using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Caso", menuName = "Paciente/Caso")]

public class Caso : ScriptableObject
{
    public string historiaClinica;

    public string dialogo1;
    public string dialogo2;

    public string FrequenciaCardiaca;
    public string PressaoArterial;
    public string Saturacao;
    public string FrequenciaRespiratoria;
    public string Temperatura;

    public string Neurologico;
    public string Respiratorio;
    public string Cardiocirculatorio;
    public string Gastrintestinal;
    public string Renal;

    public Sprite Imagem;
    public string descricaoImagem;
    public string lab1;
    public string lab2;
    public string lab3;
    public string lab4;

    public List<int> indexesCorretos;
    public List<int> selecionados;

    public int buttonCorreto;

    public bool abriuProtocolo = false;
    public bool chamouEquipe = false;
    public bool apertouBotaoCorreto = false;
    //masculino = true; feminino = false;
    public bool sexo = true;

    public int pontuacao;

    public List<string> condutas;

    public List<int> condSelected;
}
