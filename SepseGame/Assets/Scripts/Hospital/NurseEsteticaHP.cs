using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseEsteticaHP : MonoBehaviour
{
    public GameObject PersonagemMasculino;
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
    public int gender, corDaPele, hasBigas, hasCabas, hasOclin, cabelin, bigas, sexo, role, estetoscopio, mascara;

    // Start is called before the first frame update
    void Start()
    {
        SetSkin();
    }
    public void SetSkin()
    {
        gender = EsteticaNurse.gender;

        if (gender == 0)
        {
            SetSkinMale();
           
        }
        else if (gender == 1)
        {
            Color corzinha = EsteticaNurse.corRoupa;

            // ativacao do personagem
            PersonagemMasculino.SetActive(false);
            PersonagemFeminino.SetActive(true);

            // recepcao e declaracao de indices
            GameObject PeleF = GameObject.Find("PeleF");
            GameObject CabeloF = GameObject.Find("CabelinF");
            GameObject BlusaF = GameObject.Find("BlusaF");
            GameObject ProfissaoF = GameObject.Find("ProfissaoF");
            GameObject Oclin = GameObject.Find("AcessorioRostoF");
            GameObject EstetoscopioF = GameObject.Find("EstetoscopioF");
            GameObject MascaraF = GameObject.Find("MascaraF");
            GameObject CalcaF = GameObject.Find("CalcaF");

            corDaPele = EsteticaNurse.corDaPele;
            cabelin = EsteticaNurse.cabelin;
            estetoscopio = EsteticaNurse.estetoscopio;
            hasOclin = EsteticaNurse.hasOclin;
            role = EsteticaNurse.role;
            mascara = EsteticaNurse.mascara;
            EsteticaNurse.cabelin = cabelin;

            PeleF.GetComponent<SpriteRenderer>().sprite = peleArrayF[corDaPele];
            CabeloF.GetComponent<SpriteRenderer>().sprite = cabeloArrayF[cabelin];
            BlusaF.GetComponent<SpriteRenderer>().color = corzinha;
            CalcaF.GetComponent<SpriteRenderer>().color = corzinha;

            //condicoes
            if (role < 50)
            {
                role = 0;
                ProfissaoF.GetComponent<SpriteRenderer>().sprite = profissaoArray[role];
            }
            else
            {
                role = 1;
                ProfissaoF.GetComponent<SpriteRenderer>().sprite = profissaoArray[role];

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

            if (hasOclin < 35)
            {
                Oclin.GetComponent<SpriteRenderer>().sprite = oclinSprite;
            }
            else
            {
                Oclin.GetComponent<SpriteRenderer>().sprite = null;
            }
        }
    }

    public void SetSkinMale()
    {
        Color corzinha = EsteticaNurse.corRoupa;

        // ativacao do personagem
        PersonagemMasculino.SetActive(true);
        PersonagemFeminino.SetActive(false);

        // recepcao e declaracao de indices
        GameObject EstetoscopioM = GameObject.Find("EstetoscopioM");
        GameObject PeloFacialM = GameObject.Find("PeloFacialM");
        GameObject OclinM = GameObject.Find("AcessorioRostoM");
        GameObject ProfissaoM = GameObject.Find("ProfissaoM");
        GameObject MascaraM = GameObject.Find("MascaraM");
        GameObject CabeloM = GameObject.Find("CabelinM");
        GameObject CalcaM = GameObject.Find("CalcaM");
        GameObject BlusaM = GameObject.Find("BlusaM");
        GameObject PeleM = GameObject.Find("PeleM");

        cabelin = EsteticaNurse.cabelin;
        corDaPele = EsteticaNurse.corDaPele;
        bigas = EsteticaNurse.bigas;
        role = EsteticaNurse.role;
        estetoscopio = EsteticaNurse.estetoscopio;
        mascara = EsteticaNurse.mascara;
        hasOclin = EsteticaNurse.hasOclin;

        CabeloM.GetComponent<SpriteRenderer>().sprite = cabeloArray[cabelin];
        PeleM.GetComponent<SpriteRenderer>().sprite = peleArray[corDaPele];
        PeloFacialM.GetComponent<SpriteRenderer>().sprite = barbaArray[bigas];
        BlusaM.GetComponent<SpriteRenderer>().color = corzinha;
        CalcaM.GetComponent<SpriteRenderer>().color = corzinha;

        // condicoes
        if (role < 50)
        {
            role = 0;
            ProfissaoM.GetComponent<SpriteRenderer>().sprite = profissaoArray[role];
        }
        else
        {
            role = 1;
            ProfissaoM.GetComponent<SpriteRenderer>().sprite = profissaoArray[role];

        }

        if (estetoscopio < 50)
        {
            estetoscopio = 0;
            EstetoscopioM.GetComponent<SpriteRenderer>().sprite = estetoscopioArray[estetoscopio];
        }
        else
        {
            estetoscopio = 1;
            EstetoscopioM.GetComponent<SpriteRenderer>().sprite = estetoscopioArray[estetoscopio];
        }

        if (mascara < 50)
        {
            mascara = 0;
            MascaraM.GetComponent<SpriteRenderer>().sprite = mascaraArray[mascara];
        }
        else
        {
            mascara = 1;
            MascaraM.GetComponent<SpriteRenderer>().sprite = mascaraArray[mascara];

        }

        if (hasOclin < 35)
        {
            OclinM.GetComponent<SpriteRenderer>().sprite = oclinSprite;
        }
        else
        {
            OclinM.GetComponent<SpriteRenderer>().sprite = null;
        }
    }

}
