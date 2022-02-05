using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Toggle : MonoBehaviour
{
    [HideInInspector]
    public GameObject Toggle1;
    [HideInInspector]
    public GameObject Toggle2;
    [HideInInspector]
    public GameObject Toggle3;
    [HideInInspector]
    public GameObject Toggle4;
    [HideInInspector]
    public GameObject Toggle5;
    [HideInInspector]
    public GameObject Toggle6;
    [HideInInspector]
    public GameObject Toggle7;
    [HideInInspector]
    public GameObject Toggle8;
    [HideInInspector]
    public GameObject Confirm;

    bool check1 = false;
    bool check2 = false;
    bool check3 = false;
    bool check4 = false;
    bool check5 = false;
    bool check6 = false;
    bool check7 = false;
    bool check8 = false;


    public void CheckBox1()
    {
        check1 = Verificar(check1);
    }
    public void CheckBox2()
    {
        check2 = Verificar(check2);
    }
    public void CheckBox3()
    {
        check3 = Verificar(check3);
    }
    public void CheckBox4()
    {
        check4 = Verificar(check4);
    }
    public void CheckBox5()
    {
        check5 = Verificar(check5);
    }
    public void CheckBox6()
    {
        check6 = Verificar(check6);
    }
    public void CheckBox7()
    {
        check7 = Verificar(check7);
    }
    public void CheckBox8()
    {
        check8 = Verificar(check8);
    }

    private bool Verificar(bool check)
    {
        if (check == false)
        {
            check = true;
            return check;
        }
        if (check == true)
        {
            check = false;
            return check;
        }
        return check;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
