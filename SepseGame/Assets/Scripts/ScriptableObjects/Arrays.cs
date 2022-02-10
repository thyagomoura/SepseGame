using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : ScriptableObject
{
    readonly string[] PressaoNormal = {"120/80mmHg", "126/82mmHg", "100/81mmHg", "95/80mmHg"};
    readonly string[] PressaoAnormal = {"140/90mmHg", "155/95mmHg", "162/103mmHg", "180/110mmHg"};

    readonly string[] CardiacaNormal = {"70bpm", "80bpm", "90bpm" };
    readonly string[] CardiacaAnormal = { "110bpm", "120bpm", "130bpm", "50bpm", "40bpm" };

    readonly string[] RespiratoriaNormal = {"13rpm", "14rpm", "15rpm", "16rpm", "17rpm", "18rpm", "19rpm"};
    readonly string[] RespiratoriaAnormal = {"10rpm", "9rpm", "8rpm", "23rpm", "24rpm", "25rpm", "26rpm"};

    readonly string[] SaturacaoNormal = {"95%", "96%", "97%", "98%", "99%"};
    readonly string[] SaturacaoAnormal = {"90%", "80%", "70%", "60%"};

    readonly string[] TemperaturaNormal = {"36,5ºC", "37ºC"};
    readonly string[] TemperaturaAnormal = {"37,5ºC", "38ºC", "38,5ºC", "39ºC", "39,5ºC"};

    readonly string[] GlicemiaNormal = {"80mg/dL", "90mg/dL", "100mg/dL"};
    readonly string[] GlicemiaAnormal = {"60mg/dL", "50mg/dL", "120mgdL", "130mg/dL"};

    readonly string[] DebitoNormal = {"0,5mL/kg/h"};
    readonly string[] DebitoAnormal = {""};
}
