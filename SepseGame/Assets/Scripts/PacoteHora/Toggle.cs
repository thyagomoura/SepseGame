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

    //bug na contagem de certas
    //fazer tela quando confirmar e mostrar oq acertou

    private void Start()
    {
        RandomText();

    }
    //checkbox
        public void CheckBox1()
    {
        check1 = Verificar(check1);
        if (check1==true)
        {
            certas = VerificarCertas(random1, check1);
        }
        else if (check1==false)
        {
            certas = VerificarErradas(random1, check1);
        }
        Debug.Log(certas);
    }
    public void CheckBox2()
    {
        check2 = Verificar(check2);
        if (check2 == true)
        {
            certas = VerificarCertas(random2, check2);
        }
        else if (check2 == false)
        {
            certas = VerificarErradas(random2, check2);
        }
        Debug.Log(certas);
    }
    public void CheckBox3()
    {
        check3 = Verificar(check3);
        if (check3 == true)
        {
            certas = VerificarCertas(random3, check3);
        }
        else if (check1 == false)
        {
            certas = VerificarErradas(random3, check3);
        }
        Debug.Log(certas);
    }
    public void CheckBox4()
    {
        check4 = Verificar(check4);
        if (check4 == true)
        {
            certas = VerificarCertas(random4, check4);
        }
        else if (check4 == false)
        {
            Debug.Log(check4);
            certas = VerificarErradas(random4, check4);
        }
        Debug.Log(certas);
    }
    public void CheckBox5()
    {
        check5 = Verificar(check5);
        if (check5 == true)
        {
            certas = VerificarCertas(random5, check5);
        }
        else if (check5 == false)
        {
            certas = VerificarErradas(random5, check5);
        }
        Debug.Log(certas);
    }
    public void CheckBox6()
    {
        check6 = Verificar(check6);
        if (check6 == true)
        {
            certas = VerificarCertas(random6, check6);
        }
        else if (check6 == false)
        {
            certas = VerificarErradas(random6, check6);
        }
        Debug.Log(certas);
    }
    public void CheckBox7()
    {
        check7 = Verificar(check7);
        if (check7 == true)
        {
            certas = VerificarCertas(random7, check7);
        }
        else if (check7 == false)
        {
            certas = VerificarErradas(random7, check7);
        }
        Debug.Log(certas);
    }
    public void CheckBox8()
    {
        check8 = Verificar(check8);
        if (check8 == true)
        {
            certas = VerificarCertas(random8, check8);
        }
        else if (check8 == false)
        {
            certas = VerificarErradas(random8, check8);
        }
        Debug.Log(certas);
    }
    //verificar acertos do user
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

    private int VerificarCertas(int random, bool check)
    {
        if (check == true)
        {
            if (random == 0 || random == 1 || random == 2 || random == 3)
            {
                certas++;
                return certas;
            }
        }

        return certas;
    }

    private int VerificarErradas(int random1,bool check1)
    {
        certas--;
        return certas;
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
 
}
