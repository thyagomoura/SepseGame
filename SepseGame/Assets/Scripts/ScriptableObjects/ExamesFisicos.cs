using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ExamesFisicos", menuName = "Paciente/ExamesFisicos")]

public class ExamesFisicos : ScriptableObject
{
    public string Neurologico;
    public string Respiratorio;
    public string Cardiocirculatorio;
    public string Gastrintestinal;
    public string Renal;
}
