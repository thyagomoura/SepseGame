using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCustomize : MonoBehaviour
{
    public EsteticaNurse nurseDataPack;
    public NurseManage nurseManage;
    public GameObject enfermeiro;

    public void BackMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void GoDialog()
    {
        PrefabUtility.SaveAsPrefabAsset(enfermeiro, "Assets/Prefabs/Nurse.prefab");
        SceneManager.LoadScene("Dialogo");
    }
}
