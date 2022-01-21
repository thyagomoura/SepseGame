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

    public GameObject PersonagemMasculino;
    public GameObject PersonagemFeminino;

    void Awake()
    {
        Generate();
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
        GenerateMale();
    }

    void GenerateMale()
    {
        PersonagemMasculino.SetActive(true);
        PersonagemFeminino.SetActive(false);

        GameObject Pele = GameObject.Find("Pele");
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject Blusa = GameObject.Find("Blusa");
        GameObject Calca = GameObject.Find("Calca");
        GameObject CalcaOutline = GameObject.Find("CalcaOutline");
        GameObject Pisante = GameObject.Find("Pisante");
        GameObject PeloFacial = GameObject.Find("PeloFacial");

        int corDaPele = Random.Range(0, 3);

        int hasBigas = Random.Range(0, 2);
        int hasCabas = Random.Range(0, 99);
        int hasCorta = Random.Range(0, 2);
        int hasCalca = Random.Range(0, 2);

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

        Blusa.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        Calca.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
        Pisante.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 0, 0.75f, 1, 1);
    }

    void GenerateFemale()
    {

    }
}
