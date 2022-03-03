using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Aferidos", menuName = "Paciente/Aferidos")]

public class Aferidos : ScriptableObject 
{
    public List<int> IndexesAferidos = new List<int>();
}
//lista que contem os sinais vitais aferidos mas nao selecionados