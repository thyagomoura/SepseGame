using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Selecionados", menuName = "Paciente/Selecionados")]

public class Selecionados : ScriptableObject
{
    public List<int> Selected = new List<int>();
}
