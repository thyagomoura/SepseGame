using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetTutorial : MonoBehaviour
{
    public GameObject Tutorial, BBG, Box, TopTitle, Exit;
    public Estetica pack;
    // Start is called before the first frame update
    void Start()
    {
        string cs = SceneManager.GetActiveScene().name;
        if (pack.currentCase == 0 && cs == "Dialogo")
        {
            Tutorial.SetActive(true);
            BBG.SetActive(true);
            Box.SetActive(true);
            TopTitle.SetActive(true);
            Exit.SetActive(true);
        }
    }
}
