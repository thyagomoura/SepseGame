using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disclaimer : MonoBehaviour
{
    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        StartCoroutine(TimeCoroutine());
    }

    [System.Obsolete]
    IEnumerator TimeCoroutine()
    {
        yield return new WaitForSeconds(18);
        LoadMainMenu();
    }

    [System.Obsolete]
    void LoadMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
