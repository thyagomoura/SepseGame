using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseManage : MonoBehaviour
{
    public GameObject PersonagemMasculino;
    public GameObject BigodeOptions;
    public Sprite[] peleArray;
    public Sprite[] cabeloArray;
    public Sprite[] barbaArray;
    public Sprite blusa;
    public Sprite[] profissaoArray;
    public Sprite calca;

    public GameObject PersonagemFeminino;
    public Sprite[] peleArrayF;
    public Sprite[] cabeloArrayF;
    public Sprite blusaF;
    public Sprite[] profissaoArrayF;
    public Sprite calcaF;


    public Sprite[] oclinArray;
    public Sprite oclinSprite;
    public Sprite[] estetoscopioArray;
    public Sprite estetoscopioSprite;
    public Sprite[] mascaraArray;

    public EsteticaNurse EsteticaNurse;

    public SlideColorManager scm;

    public int gender, corDaPele, hasBigas, hasCabas, hasOclin, cabelin, bigas, sexo, role, estetoscopio, mascara;

    public Color corRoupas;


    GameObject Blusa, Calca, BlusaF, CalcaF;

    private void Start()
    {
        Blusa = GameObject.Find("Blusa");
        Calca = GameObject.Find("Calca");
        BlusaF = GameObject.Find("BlusaF");
        CalcaF = GameObject.Find("CalcaF");

        scm.slider.onValueChanged.AddListener(delegate { SetSliderColor(); });

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
            Debug.Log(EsteticaNurse.gender);
            SetFemale();
        }

    }

    void SetSliderColor()
    {
        corRoupas = scm.corFinal;
        Blusa.GetComponent<SpriteRenderer>().color = corRoupas;
        Calca.GetComponent<SpriteRenderer>().color = corRoupas;
        BlusaF.GetComponent<SpriteRenderer>().color = corRoupas;
        CalcaF.GetComponent<SpriteRenderer>().color = corRoupas;
    }

    public void Generate()
    {
        gender = Random.Range(0, 2);
        EsteticaNurse.gender = gender;
        if (gender < 1)
        {
            GenerateMale();
            //EsteticaNurse.set = true;
        }
        else
        {
            GenerateFemale();
            //EsteticaNurse.set = true;
        }
    }

    public void GenerateMale()
    {
        corDaPele = Random.Range(0, 4);

        hasBigas = Random.Range(0, 2);
        hasCabas = Random.Range(0, 100);
        hasOclin = Random.Range(0, 100);
        role = Random.Range(0, 100);
        bigas = Random.Range(0, 9);
        cabelin = Random.Range(0, 19);
        estetoscopio = Random.Range(0, 100);
        mascara = Random.Range(0, 100);

        EsteticaNurse.estetoscopio = estetoscopio;
        EsteticaNurse.corDaPele = corDaPele;
        EsteticaNurse.role = role;
        EsteticaNurse.hasBigas = hasBigas;
        EsteticaNurse.hasCabas = hasCabas;
        EsteticaNurse.hasOclin = hasOclin;
        EsteticaNurse.mascara = mascara;
        EsteticaNurse.bigas = bigas;
        EsteticaNurse.cabelin = cabelin;

        SetMale();
    }

    public void GenerateFemale()
    {
        corDaPele = Random.Range(0, 4);
        hasOclin = Random.Range(0, 2);
        cabelin = Random.Range(0, 24);
        role = Random.Range(0, 100);
        mascara = Random.Range(0, 2);
        estetoscopio = Random.Range(0, 2);

        EsteticaNurse.estetoscopio = estetoscopio;
        EsteticaNurse.role = role;
        EsteticaNurse.corDaPele = corDaPele;
        EsteticaNurse.hasOclin = hasOclin;
        EsteticaNurse.mascara = mascara;
        EsteticaNurse.cabelin = cabelin;

        SetFemale();
    }

    public void SetMale()
    {
        PersonagemMasculino.SetActive(true);
        PersonagemFeminino.SetActive(false);
        BigodeOptions.SetActive(true);

        GameObject Pele = GameObject.Find("Pele");
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject Blusa = GameObject.Find("Blusa");
        GameObject Profissao = GameObject.Find("Profissao");
        GameObject Pisante = GameObject.Find("Pisante");
        GameObject PeloFacial = GameObject.Find("PeloFacial");
        GameObject Oclin = GameObject.Find("AcessorioRosto");
        GameObject Estetoscopio = GameObject.Find("Estetoscopio");
        GameObject Mascara = GameObject.Find("Mascara");
        GameObject Calca = GameObject.Find("Calca");

        corDaPele = EsteticaNurse.corDaPele;
        hasBigas = EsteticaNurse.hasBigas;
        hasCabas = EsteticaNurse.hasCabas;
        hasOclin = EsteticaNurse.hasOclin;
        cabelin = EsteticaNurse.cabelin;
        bigas = EsteticaNurse.bigas;
        role = EsteticaNurse.role;
        estetoscopio = EsteticaNurse.estetoscopio;
        mascara = EsteticaNurse.mascara;

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

        if (role < 50)
        {
            role = 0;
            Profissao.GetComponent<SpriteRenderer>().sprite = profissaoArray[role];
        }
        else
        {
            role = 1;
            Profissao.GetComponent<SpriteRenderer>().sprite = profissaoArray[role];

        }
        if (estetoscopio < 50)
        {
            estetoscopio = 0;
            Estetoscopio.GetComponent<SpriteRenderer>().sprite = estetoscopioArray[estetoscopio];
        }
        else
        {
            estetoscopio = 1;
            Estetoscopio.GetComponent<SpriteRenderer>().sprite = estetoscopioArray[estetoscopio];

        }
        if (mascara < 50)
        {
            mascara = 0;
            Mascara.GetComponent<SpriteRenderer>().sprite = mascaraArray[mascara];
        }
        else
        {
            mascara = 1;
            Mascara.GetComponent<SpriteRenderer>().sprite = mascaraArray[mascara];

        }
        Color corzinha = EsteticaNurse.corRoupa;
        scm.MudarBolinha(corzinha);
        Blusa.GetComponent<SpriteRenderer>().color = corzinha;
        Calca.GetComponent<SpriteRenderer>().color = corzinha;

    }

    public void SetFemale()
    {
        PersonagemMasculino.SetActive(false);
        PersonagemFeminino.SetActive(true);
        BigodeOptions.SetActive(false);

        GameObject PeleF = GameObject.Find("PeleF");
        GameObject CabeloF = GameObject.Find("CabelinF");
        GameObject BlusaF = GameObject.Find("BlusaF");
        GameObject ProfissaoF = GameObject.Find("ProfissaoF");
        GameObject PisanteF = GameObject.Find("PisanteF");
        GameObject Oclin = GameObject.Find("AcessorioRostoF");
        GameObject EstetoscopioF = GameObject.Find("EstetoscopioF");
        GameObject MascaraF = GameObject.Find("MascaraF");
        GameObject CalcaF = GameObject.Find("CalcaF");

        estetoscopio = EsteticaNurse.estetoscopio;
        corDaPele = EsteticaNurse.corDaPele;
        hasOclin = EsteticaNurse.hasOclin;
        role = EsteticaNurse.role;
        mascara = EsteticaNurse.mascara;
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

        if (role < 50)
        {
            role = 0;
            ProfissaoF.GetComponent<SpriteRenderer>().sprite = profissaoArrayF[role];
        }
        else
        {
            role = 1;
            ProfissaoF.GetComponent<SpriteRenderer>().sprite = profissaoArrayF[role];

        }
        if (estetoscopio < 50)
        {
            estetoscopio = 0;
            EstetoscopioF.GetComponent<SpriteRenderer>().sprite = estetoscopioArray[estetoscopio];
        }
        else
        {
            estetoscopio = 1;
            EstetoscopioF.GetComponent<SpriteRenderer>().sprite = estetoscopioArray[estetoscopio];

        }
        if (mascara < 50)
        {
            mascara = 0;
            MascaraF.GetComponent<SpriteRenderer>().sprite = mascaraArray[mascara];
        }
        else
        {
            mascara = 1;
            MascaraF.GetComponent<SpriteRenderer>().sprite = mascaraArray[mascara];

        }

        Color corzinha = EsteticaNurse.corRoupa;
        scm.MudarBolinha(corzinha);
        BlusaF.GetComponent<SpriteRenderer>().color = corzinha;
        CalcaF.GetComponent<SpriteRenderer>().color = corzinha;
    }

}
