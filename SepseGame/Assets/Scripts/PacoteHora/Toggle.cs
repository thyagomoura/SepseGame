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

    string[] txt = new string[] { "certo1", "certo2", "certo3", "certo4", "errado1", "errado2", "errado3", "errado4" };
    int certas = 0;
    int random1 = 0;
    int random2 = 0;
    int random3 = 0;
    int random4 = 0;
    int random5 = 0;
    int random6 = 0;
    int random7 = 0;
    int random8 = 0;

    private void Start()
    {
        RandomText();

    }

        public void CheckBox1()
    {
        check1 = Verificar(check1, random1);
    }
    public void CheckBox2()
    {
        check2 = Verificar(check2, random2);
    }
    public void CheckBox3()
    {
        check3 = Verificar(check3, random3);
    }
    public void CheckBox4()
    {
        check4 = Verificar(check4, random4);
    }
    public void CheckBox5()
    {
        check5 = Verificar(check5, random5);
    }
    public void CheckBox6()
    {
        check6 = Verificar(check6, random6);
    }
    public void CheckBox7()
    {
        check7 = Verificar(check7, random7);
    }
    public void CheckBox8()
    {
        check8 = Verificar(check8, random8);
    }

    private bool Verificar(bool check, int random)
    {
        if (check == false)
        {
            check = true;
            if (random==0 || random==1 || random==2 || random==3)
            {
                certas++;
                Debug.Log(certas);
            }
            return check;
        }
        if (check == true)
        {
            check = false;
            if (random == 0 || random == 1 || random == 2 || random == 3)
            {
                certas--;
                Debug.Log(certas);
            }
            return check;
        }
        return check;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    private void RandomText()
    {
        random1 = Random.Range(0, 7);
        GameObject.Find("Label1").GetComponent<Text>().text = GameObject.Find("Label1").GetComponent<Text>().text + "" + txt[random1];


        random2 = Random.Range(0, 7);
        GameObject.Find("Label2").GetComponent<Text>().text = GameObject.Find("Label2").GetComponent<Text>().text + "" + txt[random2];


        random3 = Random.Range(0, 7);
        GameObject.Find("Label3").GetComponent<Text>().text = GameObject.Find("Label3").GetComponent<Text>().text + "" + txt[random3];


        random4 = Random.Range(0, 7);
        GameObject.Find("Label4").GetComponent<Text>().text = GameObject.Find("Label4").GetComponent<Text>().text + "" + txt[random4];


        random5 = Random.Range(0, 7);
        GameObject.Find("Label5").GetComponent<Text>().text = GameObject.Find("Label5").GetComponent<Text>().text + "" + txt[random5];


        random6 = Random.Range(0, 7);
        GameObject.Find("Label6").GetComponent<Text>().text = GameObject.Find("Label6").GetComponent<Text>().text + "" + txt[random6];


        random7 = Random.Range(0, 7);
        GameObject.Find("Label7").GetComponent<Text>().text = GameObject.Find("Label7").GetComponent<Text>().text + "" + txt[random7];


        random8 = Random.Range(0, 7);
        GameObject.Find("Label8").GetComponent<Text>().text = GameObject.Find("Label8").GetComponent<Text>().text + "" + txt[random8];

    }

    public void MostrarCertas()
    {
        Debug.Log(certas);
    }
}
