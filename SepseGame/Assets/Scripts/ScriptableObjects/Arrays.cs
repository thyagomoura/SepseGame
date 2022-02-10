using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monitorizar", menuName = "Paciente/Arrays")]
public class Arrays : ScriptableObject
{
    public readonly List<string> PressaoNormal = new List<string> {"120/80mmHg", "126/82mmHg", "100/81mmHg", "95/80mmHg"};
    public readonly List<string> PressaoAnormal = new List<string> { "140/90mmHg", "155/95mmHg", "162/103mmHg", "180/110mmHg"};

    public readonly List<string> CardiacaNormal = new List<string> { "70bpm", "80bpm", "90bpm" };
    public readonly List<string> CardiacaAnormal = new List<string> { "110bpm", "120bpm", "130bpm", "50bpm", "40bpm" };

    public readonly List<string> RespiratoriaNormal = new List<string> { "13rpm", "14rpm", "15rpm", "16rpm", "17rpm", "18rpm", "19rpm"};
    public readonly List<string> RespiratoriaAnormal = new List<string> { "10rpm", "9rpm", "8rpm", "23rpm", "24rpm", "25rpm", "26rpm"};

    public readonly List<string> SaturacaoNormal = new List<string> { "95%", "96%", "97%", "98%", "99%"};
    public readonly List<string> SaturacaoAnormal = new List<string> { "90%", "80%", "70%", "60%"};

    public readonly List<string> TemperaturaNormal = new List<string> { "36,5ºC", "37ºC"};
    public readonly List<string> TemperaturaAnormal = new List<string> { "37,5ºC", "38ºC", "38,5ºC", "39ºC", "39,5ºC"};

    public readonly List<string> GlicemiaNormal = new List<string> { "80mg/dL", "90mg/dL", "100mg/dL"};
    public readonly List<string> GlicemiaAnormal = new List<string> { "60mg/dL", "50mg/dL", "120mgdL", "130mg/dL"};

    public readonly List<string> DebitoNormal = new List<string> {"0,5mL/kg/h"};
    public readonly List<string> DebitoAnormal = new List<string> {""};
}
