using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Options : MonoBehaviour
{
    int Acertos = 0;
    string[] txt = new string[] { "certo1", "certo2", "certo3", "certo4", "errado1", "errado2", "errado3", "errado4" };
    int random1 = 0;
    int random2 = 0;
    int random3 = 0;
    int random4 = 0;
    int random5 = 0;
    int random6 = 0;
    int random7 = 0;
    int random8 = 0;

    int valorMin = 0;
    int valorMax = 8;
    List<int> numeroSorteados = new List<int>();


    private void Start()
    {
        RandomText();

    }

    private void RandomText()
    {

        if (Mathf.Abs(valorMax - valorMin)> numeroSorteados.Count)
        {
            int i = 0;
            while (i!=8)
            {
                int num = Random.Range(valorMin, valorMax);
                if (!numeroSorteados.Contains(num))
                {
                    numeroSorteados.Add(num);
                    i++;
                }
            }
        }
        else
        {
            Debug.LogError("Todos sorteados");
            return;
        }
        random1 = numeroSorteados.IndexOf(0);
        random2 = numeroSorteados.IndexOf(1);
        random3 = numeroSorteados.IndexOf(2);
        random4 = numeroSorteados.IndexOf(3);
        random5 = numeroSorteados.IndexOf(4);
        random6 = numeroSorteados.IndexOf(5);
        random7 = numeroSorteados.IndexOf(6);
        random8 = numeroSorteados.IndexOf(7);


        GameObject.Find("Label1").GetComponent<Text>().text = GameObject.Find("Label1").GetComponent<Text>().text + "" + txt[random1];

        GameObject.Find("Label2").GetComponent<Text>().text = GameObject.Find("Label2").GetComponent<Text>().text + "" + txt[random2];

        GameObject.Find("Label3").GetComponent<Text>().text = GameObject.Find("Label3").GetComponent<Text>().text + "" + txt[random3];

        GameObject.Find("Label4").GetComponent<Text>().text = GameObject.Find("Label4").GetComponent<Text>().text + "" + txt[random4];

        GameObject.Find("Label5").GetComponent<Text>().text = GameObject.Find("Label5").GetComponent<Text>().text + "" + txt[random5];

        GameObject.Find("Label6").GetComponent<Text>().text = GameObject.Find("Label6").GetComponent<Text>().text + "" + txt[random6];

        GameObject.Find("Label7").GetComponent<Text>().text = GameObject.Find("Label7").GetComponent<Text>().text + "" + txt[random7];

        GameObject.Find("Label8").GetComponent<Text>().text = GameObject.Find("Label8").GetComponent<Text>().text + "" + txt[random8];

    }

    public void Toggle1(bool tog)
    {
        if (tog)
        {
            if (random1 == 0 || random1 == 1 || random1 == 2 || random1 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog)
        {
            if (random1 == 0 || random1 == 1 || random1 == 2 || random1 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog + " : " + Acertos);
    }

    public void Toggle2(bool tog2)
    {
        if (tog2)
        {
            if (random2 == 0 || random2 == 1 || random2 == 2 || random2 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog2)
        {
            if (random2 == 0 || random2 == 1 || random2 == 2 || random2 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog2 + " : " + Acertos);
    }

    public void Toggle3(bool tog3)
    {
        if (tog3)
        {
            if (random3 == 0 || random3 == 1 || random3 == 2 || random3 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog3)
        {
            if (random3 == 0 || random3 == 1 || random3 == 2 || random3 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog3 + " : " + Acertos);
    }

    public void Toggle4(bool tog4)
    {
        if (tog4)
        {
            if (random4 == 0 || random4 == 1 || random4 == 2 || random4 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog4)
        {
            if (random4 == 0 || random4 == 1 || random4 == 2 || random4 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog4 + " : " + Acertos);
    }

    public void Toggle5(bool tog5)
    {
        if (tog5)
        {
            if (random5 == 0 || random5 == 1 || random5 == 2 || random5 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog5)
        {
            if (random5 == 0 || random5 == 1 || random5 == 2 || random5 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog5 + " : " + Acertos);
    }

    public void Toggle6(bool tog6)
    {
        if (tog6)
        {
            if (random6 == 0 || random6 == 1 || random6 == 2 || random6 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog6)
        {
            if (random6 == 0 || random6 == 1 || random6 == 2 || random6 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog6 + " : " + Acertos);
    }

    public void Toggle7(bool tog7)
    {
        if (tog7)
        {
            if (random7 == 0 || random7 == 1 || random7 == 2 || random7 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog7)
        {
            if (random7 == 0 || random7 == 1 || random7 == 2 || random7 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog7 + " : " + Acertos);

    }
    public void Toggle8(bool tog8)
    {
        if (tog8)
        {
            if (random8 == 0 || random8 == 1 || random8 == 2 || random8 == 3)
            {
                Acertos++;
            }
        }
        else if (!tog8)
        {
            if (random4 == 0 || random8 == 1 || random8 == 2 || random8 == 3)
            {
                Acertos--;
            }
        }
        Debug.Log(tog8 + " : " + Acertos);
    }

    public void LoadMinistar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Ministrar");
    }
}