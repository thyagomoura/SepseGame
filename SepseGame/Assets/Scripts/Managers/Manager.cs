using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
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

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

        int corDaPele = Random.Range(0, 3);

        int hasBigas = Random.Range(0, 2);
        int hasCabas = Random.Range(0, 99);
        int hasCorta = Random.Range(0, 2);
        int hasCalca = Random.Range(0, 2);
        int hasOclin = Random.Range(0, 99);

        Pele.GetComponent<SpriteRenderer>().sprite = peleArray[corDaPele];

        if (hasCabas > 30)
        {
            int cabelin = Random.Range(0, 18);
            Cabelo.GetComponent<SpriteRenderer>().sprite = cabeloArray[cabelin];
        }
        else
        {
            Cabelo.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (hasOclin > 40)
        {
            Oclin.GetComponent<SpriteRenderer>().sprite = oclinSprite;
        }
        else
        {
            Oclin.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (hasBigas < 1)
        {
            int bigas = Random.Range(0, 9);
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

    void GenerateFemale()
    {
        PersonagemMasculino.SetActive(false);
        PersonagemFeminino.SetActive(true);

        GameObject PeleF = GameObject.Find("PeleF");
        GameObject CabeloF = GameObject.Find("CabelinF");
        GameObject BlusaF = GameObject.Find("BlusaF");
        GameObject BlusaOutlineF = GameObject.Find("BlusaOutlineF");
        GameObject CalcaF = GameObject.Find("CalcaF");
        GameObject CalcaOutlineF = GameObject.Find("CalcaOutlineF");
        GameObject PisanteF = GameObject.Find("PisanteF");
        GameObject PeloFacialF = GameObject.Find("PeloFacialF");
        GameObject Oclin = GameObject.Find("AcessorioRostoF");

        int corDaPele = Random.Range(0, 3);

        int hasCalca = Random.Range(0, 2);
        int hasOclin = Random.Range(0, 99);

        PeleF.GetComponent<SpriteRenderer>().sprite = peleArrayF[corDaPele];

        int cabelin = Random.Range(0, 18);
        CabeloF.GetComponent<SpriteRenderer>().sprite = cabeloArrayF[cabelin];

        if (hasOclin > 40)
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
