using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Estetica", menuName = "Paciente/Estetica")]

public class Estetica : ScriptableObject
{
    public bool set = false;

    public int gender;

    public int corDaPele;
    public int hasBigas;
    public int hasCabas;
    public int hasCorta;
    public int hasCalca;
    public int hasOclin;
    public int cabelin;
    public int bigas;
}
