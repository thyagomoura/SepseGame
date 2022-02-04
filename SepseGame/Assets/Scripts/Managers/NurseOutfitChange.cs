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

    private int currentOption = 0;


    public void NextSkin()
    {
        GameObject Pele = GameObject.Find("Pele");
        GameObject PeleF = GameObject.Find("PeleF");
        if (nm.sexo == 0)
        {
            currentOption++;
            if (currentOption >= nm.peleArray.Length)
            {
                currentOption = 0;
            }
            Pele.GetComponent<SpriteRenderer>().sprite = nm.peleArray[currentOption];
        }
        else
        {
            currentOption++;
            if (currentOption >= nm.peleArray.Length)
            {
                currentOption = 0;
            }
            PeleF.GetComponent<SpriteRenderer>().sprite = nm.peleArray[currentOption];
        }
    }

    public void PreviousSkin()
    {
        GameObject Pele = GameObject.Find("Pele");
        GameObject PeleF = GameObject.Find("PeleF");
        if (nm.sexo == 0)
        {
            currentOption--;
            if (currentOption < 0)
            {
                currentOption = nm.peleArray.Length - 1;
            }
            Pele.GetComponent<SpriteRenderer>().sprite = nm.peleArray[currentOption];
        }
        else
        {
            currentOption++;
            if (currentOption < 0)
            {
                currentOption = nm.peleArray.Length - 1;
            }
            PeleF.GetComponent<SpriteRenderer>().sprite = nm.peleArrayF[currentOption];
        }
    }
    public void NextHair()
    {
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject CabeloF = GameObject.Find("CabelinF");
        if (nm.sexo == 0)
        {
            currentOption++;
            if (currentOption >= nm.cabeloArray.Length)
            {
                currentOption = 0;
            }
            Cabelo.GetComponent<SpriteRenderer>().sprite = nm.cabeloArray[currentOption];
        }
        else
        {
            currentOption++;
            if (currentOption >= nm.cabeloArray.Length)
            {
                currentOption = 0;
            }
            CabeloF.GetComponent<SpriteRenderer>().sprite = nm.cabeloArrayF[currentOption];
        }
    }

    public void PreviousHair()
    {
        GameObject Cabelo = GameObject.Find("Cabelin");
        GameObject CabeloF = GameObject.Find("CabelinF");
        if (nm.sexo == 0)
        {
            currentOption--;
            if (currentOption < 0)
            {
                currentOption = nm.cabeloArrayF.Length - 1;
            }
            Cabelo.GetComponent<SpriteRenderer>().sprite = nm.cabeloArray[currentOption];
        }
        else
        {
            currentOption++;
            if (currentOption < 0)
            {
                currentOption = nm.cabeloArrayF.Length - 1;
            }
            CabeloF.GetComponent<SpriteRenderer>().sprite = nm.cabeloArrayF[currentOption];
        }
    }


}
