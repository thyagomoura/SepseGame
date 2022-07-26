using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NurseManageV2 : MonoBehaviour
{
    public GameObject enfermeiro;
    public GameObject masculino;
    public GameObject feminino;
    public EsteticaNurse esteticaNurse;

    // Start is called before the first frame update

    void Start()
    {

        DontDestroyOnLoad(enfermeiro);

    }

    // Update is called once per frame
    void Update()
    {
        string cs = SceneManager.GetActiveScene().name;
        //Debug.Log(cs);
        if (cs == "Hospital" || cs == "CustomizeNurse")
        {
            if (esteticaNurse.gender == 0)
                masculino.SetActive(true);
            else
                feminino.SetActive(true);
        }
        else
        {
            masculino.SetActive(false);
            feminino.SetActive(false);
        }

        if (cs == "Hospital")
        {
            enfermeiro.transform.position = new Vector3(-4.5f, -0.3f, 0);
            enfermeiro.transform.localScale = new Vector3(5, 5, 0);
        }
    }
}
