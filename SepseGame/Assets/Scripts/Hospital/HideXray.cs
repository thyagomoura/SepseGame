using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideXray : MonoBehaviour
{
    public GameObject xrayPanel;

    private void OnMouseDown()
    {
        xrayPanel.SetActive(false);
    }
}
