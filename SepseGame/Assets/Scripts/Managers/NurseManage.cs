using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseManage : MonoBehaviour
{
    public Sprite[] peleArray;
    public Sprite[] cabeloArray;
    public Sprite[] barbaArray;
    public Sprite calca;
    public Sprite[] blusaArray;

    public Sprite[] peleArrayF;
    public Sprite[] cabeloArrayF;
    public Sprite calcaF;

    public Sprite oclinSprite;
    public Sprite[] oclinArray;
    public GameObject PersonagemMasculino;
    public GameObject PersonagemFeminino;

    public EsteticaNurse EsteticaNurse;

    public int corDaPele, hasBigas, hasCabas, /*hasCorta*/ hasOclin, cabelin, bigas, sexo;

    private void Start()
    {
        if (!EsteticaNurse.set)
        {
            Generate();
        }
        else if (EsteticaNurse.gender == 0)
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Generate();
        }
    }

    public void Generate()
    {
        int gender = Random.Range(0, 2);
        EsteticaNurse.gender = gender;
        EsteticaNurse.set = true;
        if (gender < 1)
        {
            GenerateMale();
        }
        else
        {
            GenerateFemale();
        }
    }

    public void GenerateMale()
    {
        corDaPele = Random.Range(0, 4);

        hasBigas = Random.Range(0, 2);
        hasCabas = Random.Range(0, 100);
        /*hasCorta = Random.Range(0, 2);*/
        hasOclin = Random.Range(0, 100);

        bigas = Random.Range(0, 9);
        cabelin = Random.Range(0, 19);

        EsteticaNurse.corDaPele = corDaPele;

        EsteticaNurse.hasBigas = hasBigas;
        EsteticaNurse.hasCabas = hasCabas;
        /*EsteticaNurse.hasCorta = hasCorta;*/
        EsteticaNurse.hasOclin = hasOclin;

        EsteticaNurse.bigas = bigas;
        EsteticaNurse.cabelin = cabelin;

        SetMale();
    }

    public void GenerateFemale()
    {
        corDaPele = Random.Range(0, 4);

        hasOclin = Random.Range(0, 100);

        cabelin = Random.Range(0, 24);

        EsteticaNurse.corDaPele = corDaPele;
        EsteticaNurse.hasOclin = hasOclin;

        EsteticaNurse.cabelin = cabelin;

        SetFemale();
    }

    public void SetMale()
    {
        PersonagemMasculino.SetActive(true);
        PersonagemFeminino.SetActive(false);

        GameObject Pele = GameObject.Find("Pele");
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject Blusa = GameObject.Find("Blusa");
        GameObject BlusaOutline = GameObject.Find("BlusaOutline");
        GameObject Pisante = GameObject.Find("Pisante");
        GameObject PeloFacial = GameObject.Find("PeloFacial");
        GameObject Oclin = GameObject.Find("AcessorioRosto");

        corDaPele = EsteticaNurse.corDaPele;
        hasBigas = EsteticaNurse.hasBigas;
        hasCabas = EsteticaNurse.hasCabas;
        /*hasCorta = EsteticaNurse.hasCorta;*/
        hasOclin = EsteticaNurse.hasOclin;
        cabelin = EsteticaNurse.cabelin;
        bigas = EsteticaNurse.bigas;

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

        /*if (hasCorta < 1)
        {
            BlusaOutline.GetComponent<SpriteRenderer>().sprite = blusaArray[0];
            Blusa.GetComponent<SpriteRenderer>().sprite = blusaArray[1];
        }
        else
        {
            BlusaOutline.GetComponent<SpriteRenderer>().sprite = blusaArray[2];
            Blusa.GetComponent<SpriteRenderer>().sprite = blusaArray[3];
        }*/

        Blusa.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        Pisante.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
    }

    public void SetFemale()
    {
        PersonagemMasculino.SetActive(false);
        PersonagemFeminino.SetActive(true);

        GameObject PeleF = GameObject.Find("PeleF");
        GameObject CabeloF = GameObject.Find("CabelinF");
        GameObject BlusaF = GameObject.Find("BlusaF");
        // GameObject CalcaF = GameObject.Find("CalcaF");
        // GameObject CalcaOutlineF = GameObject.Find("CalcaOutlineF");
        GameObject PisanteF = GameObject.Find("PisanteF");
        GameObject Oclin = GameObject.Find("AcessorioRostoF");

        corDaPele = EsteticaNurse.corDaPele;
        hasOclin = EsteticaNurse.hasOclin;

        EsteticaNurse.cabelin = cabelin;

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

        BlusaF.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        // CalcaF.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        PisanteF.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
    }


}
