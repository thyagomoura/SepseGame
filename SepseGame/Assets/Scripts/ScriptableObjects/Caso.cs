using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Caso", menuName = "Paciente/Caso")]

public class Caso : ScriptableObject
{
    public string dialogo1;
    public string dialogo2;

    public string FrequenciaCardiaca;
    public string PressaoArterial;
    public string Saturacao;
    public string FrequenciaRespiratoria;
    public string Temperatura;
    public string Glicemia;

    public string Neurologico;
    public string Respiratorio;
    public string Cardiocirculatorio;
    public string Gastrintestinal;
    public string Renal;

    public Sprite Imagem;
    public string Laboratorial;

    public List<int> indexesCorretos;
}
