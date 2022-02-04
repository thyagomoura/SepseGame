using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacienteManager : MonoBehaviour
{
    public Sprite[] peleArray;
    public Sprite[] cabeloArray;
    public Sprite[] barbaArray;
    public Sprite[] calcaArray;
    public Sprite[] blusaArray;

    public Sprite[] peleArrayF;
    public Sprite[] cabeloArrayF;
    public Sprite[] calcaArrayF;

    public Sprite oclinSprite;

    public GameObject PersonagemMasculino;
    public GameObject PersonagemFeminino;

    public Estetica Estetica;

    public int corDaPele, hasBigas, hasCabas, hasCorta, hasCalca, hasOclin, cabelin, bigas;

    private void Start()
    {
        if (!Estetica.set)
        {
            Generate();
        }
        else if(Estetica.gender == 0)
        {
            SetMale();
        }
        else
        {
            SetFemale();
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Generate();
        }
    }

    public void Generate()
    {
        int gender = Random.Range(0, 2);
        Estetica.gender = gender;
        Estetica.set = true;
        if (gender < 1)
        {
            GenerateMale();
        }
        else
        {
            GenerateFemale();
        }
    }

    void GenerateMale()
    {
        corDaPele = Random.Range(0, 4);

        hasBigas = Random.Range(0, 2);
        hasCabas = Random.Range(0, 100);
        hasCorta = Random.Range(0, 2);
        hasCalca = Random.Range(0, 2);
        hasOclin = Random.Range(0, 100);

        bigas = Random.Range(0, 9);
        cabelin = Random.Range(0, 19);

        Estetica.corDaPele = corDaPele;

        Estetica.hasBigas = hasBigas;
        Estetica.hasCabas = hasCabas;
        Estetica.hasCorta = hasCorta;
        Estetica.hasCalca = hasCalca;
        Estetica.hasOclin = hasOclin;

        Estetica.bigas = bigas;
        Estetica.cabelin = cabelin;

        SetMale();
    }

    void GenerateFemale()
    {
        corDaPele = Random.Range(0, 4);

        hasCalca = Random.Range(0, 2);
        hasOclin = Random.Range(0, 100);

        cabelin = Random.Range(0, 24);

        Estetica.corDaPele = corDaPele;
        Estetica.hasCalca = hasCalca;
        Estetica.hasOclin = hasOclin;

        Estetica.cabelin = cabelin;

        SetFemale();
    }

    void SetMale()
    {
        PersonagemMasculino.SetActive(true);
        PersonagemFeminino.SetActive(false);

        GameObject Pele = GameObject.Find("Pele");
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject Blusa = GameObject.Find("Blusa");
        GameObject BlusaOutline = GameObject.Find("BlusaOutline");
        GameObject Calca = GameObject.Find("Calca");
        GameObject CalcaOutline = GameObject.Find("CalcaOutline");
        GameObject Pisante = GameObject.Find("Pisante");
        GameObject PeloFacial = GameObject.Find("PeloFacial");
        GameObject Oclin = GameObject.Find("AcessorioRosto");

        corDaPele = Estetica.corDaPele;
        hasBigas = Estetica.hasBigas;
        hasCabas = Estetica.hasCabas;
        hasCorta = Estetica.hasCorta;
        hasCalca = Estetica.hasCalca;
        hasOclin = Estetica.hasOclin;
        cabelin = Estetica.cabelin;
        bigas = Estetica.bigas;

        Pele.GetComponent<SpriteRenderer>().sprite = peleArray[corDaPele];

        if (hasCabas > 30)
        {
            Cabelo.GetComponent<SpriteRenderer>().sprite = cabeloArray[cabelin];
        }
        else
        {
            Cabelo.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (hasOclin < 35)
        {
            Oclin.GetComponent<SpriteRenderer>().sprite = oclinSprite;
        }
        else
        {
            Oclin.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (hasBigas < 1)
        {
            PeloFacial.GetComponent<SpriteRenderer>().sprite = barbaArray[bigas];
        }
        else
        {
            PeloFacial.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (hasCalca < 1)
        {
            CalcaOutline.GetComponent<SpriteRenderer>().sprite = calcaArray[0];
            Calca.GetComponent<SpriteRenderer>().sprite = calcaArray[1];
        }
        else
        {
            CalcaOutline.GetComponent<SpriteRenderer>().sprite = calcaArray[2];
            Calca.GetComponent<SpriteRenderer>().sprite = calcaArray[3];
        }

        if (hasCorta < 1)
        {
            BlusaOutline.GetComponent<SpriteRenderer>().sprite = blusaArray[0];
            Blusa.GetComponent<SpriteRenderer>().sprite = blusaArray[1];
        }
        else
        {
            BlusaOutline.GetComponent<SpriteRenderer>().sprite = blusaArray[2];
            Blusa.GetComponent<SpriteRenderer>().sprite = blusaArray[3];
        }

        Blusa.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        Calca.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        Pisante.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
    }

    void SetFemale()
    {
        PersonagemMasculino.SetActive(false);
        PersonagemFeminino.SetActive(true);

        GameObject PeleF = GameObject.Find("PeleF");
        GameObject CabeloF = GameObject.Find("CabelinF");
        GameObject BlusaF = GameObject.Find("BlusaF");
        GameObject CalcaF = GameObject.Find("CalcaF");
        GameObject CalcaOutlineF = GameObject.Find("CalcaOutlineF");
        GameObject PisanteF = GameObject.Find("PisanteF");
        GameObject Oclin = GameObject.Find("AcessorioRostoF");

        corDaPele = Estetica.corDaPele;
        hasCalca = Estetica.hasCalca;
        hasOclin = Estetica.hasOclin;

        cabelin = Estetica.cabelin;

        PeleF.GetComponent<SpriteRenderer>().sprite = peleArrayF[corDaPele];

        CabeloF.GetComponent<SpriteRenderer>().sprite = cabeloArrayF[cabelin];

        if (hasOclin < 35)
        {
            Oclin.GetComponent<SpriteRenderer>().sprite = oclinSprite;
        }
        else
        {
            Oclin.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (hasCalca < 1)
        {
            CalcaOutlineF.GetComponent<SpriteRenderer>().sprite = calcaArrayF[0];
            CalcaF.GetComponent<SpriteRenderer>().sprite = calcaArrayF[1];
        }
        else
        {
            CalcaOutlineF.GetComponent<SpriteRenderer>().sprite = calcaArrayF[2];
            CalcaF.GetComponent<SpriteRenderer>().sprite = calcaArrayF[3];
        }

        BlusaF.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        CalcaF.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        PisanteF.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
    }
}
