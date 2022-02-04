using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monitorizar", menuName = "Paciente/Monitorizar")]

public class Monitorizar : ScriptableObject
{
    public int PressaoArterial;
    public int FrequenciaCardiaca;
    public int FrequenciaRespiratoria;
    public int Saturacao;
    public int Temperatura;
    public int Glicemia;
    public int DebitoUrinario;
}
