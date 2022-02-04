using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseOutfitChange : MonoBehaviour
{
    public NurseManage nm;

    public void Randomize()
    {
        nm.Generate();
    }

    private int currentOptionSkin = 0;
    private int currentOptionHair = 0;
    private int currentOptionBigas = 0;
    private int currentOptionOclin = 0;
    public void SexoM()
    {
        nm.SetMale();
        nm.GenerateMale();
        nm.sexo = 0;
    }
    public void SexoF() {
        nm.SetFemale();
        nm.GenerateFemale();
        nm.sexo = 1;
    }
    public void NextSkin()
    {
        GameObject Pele = GameObject.Find("Pele");
        GameObject PeleF = GameObject.Find("PeleF");
        if (nm.sexo == 0)
        {
            currentOptionSkin++;
            if (currentOptionSkin >= nm.peleArray.Length)
            {
                currentOptionSkin = 0;
            }
            Pele.GetComponent<SpriteRenderer>().sprite = nm.peleArray[currentOptionSkin];
        }
        else
        {
            currentOptionSkin++;
            if (currentOptionSkin >= nm.peleArray.Length)
            {
                currentOptionSkin = 0;
            }
            PeleF.GetComponent<SpriteRenderer>().sprite = nm.peleArray[currentOptionSkin];
        }
    }

    public void PreviousSkin()
    {
        GameObject Pele = GameObject.Find("Pele");
        GameObject PeleF = GameObject.Find("PeleF");
        if (nm.sexo == 0)
        {
            currentOptionSkin--;
            if (currentOptionSkin < 0)
            {
                currentOptionSkin = nm.peleArray.Length - 1;
            }
            Pele.GetComponent<SpriteRenderer>().sprite = nm.peleArray[currentOptionSkin];
        }
        else
        {
            currentOptionSkin++;
            if (currentOptionSkin < 0)
            {
                currentOptionSkin = nm.peleArray.Length - 1;
            }
            PeleF.GetComponent<SpriteRenderer>().sprite = nm.peleArrayF[currentOptionSkin];
        }
    }
    public void NextHair()
    {
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject CabeloF = GameObject.Find("CabelinF");
        if (nm.sexo == 0)
        {
            currentOptionHair++;
            if (currentOptionHair >= nm.cabeloArray.Length)
            {
                currentOptionHair = 0;
            }
            Cabelo.GetComponent<SpriteRenderer>().sprite = nm.cabeloArray[currentOptionHair];
        }
        else
        {
            currentOptionHair++;
            if (currentOptionHair >= nm.cabeloArray.Length)
            {
                currentOptionHair = 0;
            }
            CabeloF.GetComponent<SpriteRenderer>().sprite = nm.cabeloArrayF[currentOptionHair];
        }
    }

    public void PreviousHair()
    {
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject CabeloF = GameObject.Find("CabelinF");
        if (nm.sexo == 0)
        {
            currentOptionHair--;
            if (currentOptionHair < 0)
            {
                currentOptionHair = nm.cabeloArrayF.Length - 1;
            }
            Cabelo.GetComponent<SpriteRenderer>().sprite = nm.cabeloArray[currentOptionHair];
        }
        else
        {
            currentOptionHair++;
            if (currentOptionHair < 0)
            {
                currentOptionHair = nm.cabeloArrayF.Length - 1;
            }
            CabeloF.GetComponent<SpriteRenderer>().sprite = nm.cabeloArrayF[currentOptionHair];
        }
    }

    public void NextOclin()
    {
        Debug.Log(currentOptionOclin);
        GameObject Oclin = GameObject.Find("AcessorioRosto");
        currentOptionOclin++;
        if (currentOptionOclin >= nm.oclinArray.Length)
        {
            currentOptionOclin = 0;
        }
        Oclin.GetComponent<SpriteRenderer>().sprite = nm.oclinArray[currentOptionOclin];

    }

    public void PreviousOclin()
    {
        GameObject Oclin = GameObject.Find("AcessorioRosto");

        currentOptionOclin--;
        if (currentOptionOclin < 0)
        {
            currentOptionOclin = nm.oclinArray.Length - 1;
        }
        Oclin.GetComponent<SpriteRenderer>().sprite = nm.oclinArray[currentOptionOclin];


    }

    public void NextBigas()
    {
        GameObject PeloFacial = GameObject.Find("PeloFacial");


        currentOptionBigas++;
        if (currentOptionBigas >= nm.barbaArray.Length)
        {
            currentOptionBigas = 0;
        }
        PeloFacial.GetComponent<SpriteRenderer>().sprite = nm.barbaArray[currentOptionBigas];

    }

    public void PreviousBigas()
    {
        GameObject PeloFacial = GameObject.Find("PeloFacial");


        currentOptionBigas--;
        if (currentOptionBigas < 0)
        {
            currentOptionBigas = nm.barbaArray.Length - 1;
        }
        PeloFacial.GetComponent<SpriteRenderer>().sprite = nm.barbaArray[currentOptionBigas];

    }
}
