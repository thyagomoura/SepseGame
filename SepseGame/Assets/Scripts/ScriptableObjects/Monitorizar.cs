using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monitorizar", menuName = "Paciente/Monitorizar")]

public class Monitorizar : ScriptableObject
{
    public string PressaoArterial;
    public string FrequenciaCardiaca;
    public string FrequenciaRespiratoria;
    public string Saturacao;
    public string Temperatura;
    public string Glicemia;
    public string DebitoUrinario;


}
