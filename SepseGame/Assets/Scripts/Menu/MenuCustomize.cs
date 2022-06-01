using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCustomize : MonoBehaviour
{
    public EsteticaNurse nurseDataPack;
    public NurseManage nurseManage;

    public void BackMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
       
}
