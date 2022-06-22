using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PacotaoGridItem : MonoBehaviour
{
    public int condutaIndex;

    public GameObject objText;

    public void updt(int ordem)
    {
        objText.GetComponent<TextMeshProUGUI>().text = ordem.ToString();
    }
}
