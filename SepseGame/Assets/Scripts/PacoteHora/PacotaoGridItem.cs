using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PacotaoGridItem : MonoBehaviour
{
    public int condutaIndex;

    public GameObject objText;

    public int updt(int ordem)
    {
        if ((ordem - 1).ToString() == objText.GetComponent<TextMeshProUGUI>().text)
        {
            objText.GetComponent<TextMeshProUGUI>().text = "";
            return 2;
        }
        else if (objText.GetComponent<TextMeshProUGUI>().text == "")
        {
            objText.GetComponent<TextMeshProUGUI>().text = ordem.ToString();
            return 1;
        }

        return 0;
    }

    public void rst()
    {
        objText.GetComponent<TextMeshProUGUI>().text = "";
    }
}
