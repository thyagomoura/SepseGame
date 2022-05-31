using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Caso", menuName = "Paciente/Caso")]

public class Caso : ScriptableObject
{
    public string PressaoArterial;
    public string FrequenciaCardiaca;
    public string FrequenciaRespiratoria;
    public string Saturacao;
    public string Temperatura;
    public string Glicemia;
    public string DebitoUrinario;

    public string Neurologico;
    public string Respiratorio;
    public string Cardiocirculatorio;
    public string Gastrintestinal;
    public string Renal;
}
