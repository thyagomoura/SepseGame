using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseOutfitChange : MonoBehaviour
{
    public NurseManage nm;
    private void Start()
    {
        
    }

    public void Randomize()
    {
        nm.Generate();
        nm.sexo = nm.gender;
        Debug.Log(nm.sexo);
    }

    private int currentOptionSkin = 0;
    private int currentOptionHair = 0;
    private int currentOptionBigas = 0;
    private int currentOptionOclin = 0;
    private int currentOptionEstetoscopio = 0;
    private int currentOptionMascara = 0;

    public void SexoM()
    {
        nm.GenerateMale();
        nm.sexo = 0;
        nm.gender = 0;
    }

    public void SexoF()
    {
        nm.GenerateFemale();
        nm.sexo = 1;
        nm.gender = 1;
    }

    public void Nurse()
    {
        GameObject ProfissaoF = GameObject.Find("ProfissaoF");
        GameObject Profissao = GameObject.Find("Profissao");
        if (nm.sexo == 0)
        {
            Profissao.GetComponent<SpriteRenderer>().sprite = nm.profissaoArray[0];
        }
        else
        {
            ProfissaoF.GetComponent<SpriteRenderer>().sprite = nm.profissaoArrayF[0];
        }
    }

    public void Doctor()
    {
        GameObject ProfissaoF = GameObject.Find("ProfissaoF");
        GameObject Profissao = GameObject.Find("Profissao");
        if (nm.sexo == 0)
        {
            Profissao.GetComponent<SpriteRenderer>().sprite = nm.profissaoArray[1];
        }
        else
        {
            ProfissaoF.GetComponent<SpriteRenderer>().sprite = nm.profissaoArrayF[1];
        }

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
            nm.corDaPele = currentOptionSkin;
        }
        else
        {
            currentOptionSkin++;
            if (currentOptionSkin >= nm.peleArrayF.Length)
            {
                currentOptionSkin = 0;
            }
            PeleF.GetComponent<SpriteRenderer>().sprite = nm.peleArrayF[currentOptionSkin];
            nm.corDaPele = currentOptionSkin;
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
            nm.corDaPele = currentOptionSkin;
        }
        else
        {
            currentOptionSkin--;
            if (currentOptionSkin < 0)
            {
                currentOptionSkin = nm.peleArrayF.Length - 1;
            }
            PeleF.GetComponent<SpriteRenderer>().sprite = nm.peleArrayF[currentOptionSkin];
            nm.corDaPele = currentOptionSkin;
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
            nm.hasCabas = currentOptionHair;
        }
        else
        {
            currentOptionHair++;
            if (currentOptionHair >= nm.cabeloArrayF.Length)
            {
                currentOptionHair = 0;
            }
            CabeloF.GetComponent<SpriteRenderer>().sprite = nm.cabeloArrayF[currentOptionHair];
            nm.hasCabas = currentOptionHair;
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
                currentOptionHair = nm.cabeloArray.Length - 1;
            }
            Cabelo.GetComponent<SpriteRenderer>().sprite = nm.cabeloArray[currentOptionHair];
            nm.hasCabas = currentOptionHair;
        }
        else
        {
            currentOptionHair--;
            if (currentOptionHair < 0)
            {
                currentOptionHair = nm.cabeloArrayF.Length - 1;
            }
            CabeloF.GetComponent<SpriteRenderer>().sprite = nm.cabeloArrayF[currentOptionHair];
            nm.hasCabas = currentOptionHair;
        }
    }

    public void NextOclin()
    {
        GameObject Oclin = GameObject.Find("AcessorioRosto");
        GameObject OclinF = GameObject.Find("AcessorioRostoF");
        if (nm.sexo == 0)
        {
            currentOptionOclin++;
            if (currentOptionOclin >= nm.oclinArray.Length)
            {
                currentOptionOclin = 0;
            }
            Oclin.GetComponent<SpriteRenderer>().sprite = nm.oclinArray[currentOptionOclin];
            nm.hasOclin = currentOptionOclin;
        }
        else
        {
            currentOptionOclin++;
            if (currentOptionOclin >= nm.oclinArray.Length)
            {
                currentOptionOclin = 0;
            }
            OclinF.GetComponent<SpriteRenderer>().sprite = nm.oclinArray[currentOptionOclin];
            nm.hasOclin = currentOptionOclin;
        }
    }

    public void PreviousOclin()
    {
        GameObject Oclin = GameObject.Find("AcessorioRosto");
        GameObject OclinF = GameObject.Find("AcessorioRostoF");

        if (nm.sexo == 0)
        {
            currentOptionOclin--;
            if (currentOptionOclin < 0)
            {
                currentOptionOclin = 1;
            }
            Oclin.GetComponent<SpriteRenderer>().sprite = nm.oclinArray[currentOptionOclin];
            nm.hasOclin = currentOptionOclin;
        }
        else
        {
            currentOptionOclin--;
            if (currentOptionOclin < 0)
            {
                currentOptionOclin = 1;
            }
            OclinF.GetComponent<SpriteRenderer>().sprite = nm.oclinArray[currentOptionOclin];
            nm.hasOclin = currentOptionOclin;
        }
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
        nm.hasBigas = currentOptionBigas;
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
        nm.hasBigas = currentOptionBigas;
    }

    public void NextEstetoscopio()
    {
        GameObject Estetoscopio = GameObject.Find("Estetoscopio");
        GameObject EstetoscopioF = GameObject.Find("EstetoscopioF");

        if (nm.sexo == 0)
        {
            currentOptionEstetoscopio++;
            if (currentOptionEstetoscopio >= nm.estetoscopioArray.Length)
            {
                currentOptionEstetoscopio = 0;
            }
            Estetoscopio.GetComponent<SpriteRenderer>().sprite = nm.estetoscopioArray[currentOptionEstetoscopio];
            nm.estetoscopio = currentOptionEstetoscopio;
        }
        else
        {
            currentOptionEstetoscopio++;
            if (currentOptionEstetoscopio >= nm.estetoscopioArray.Length)
            {
                currentOptionEstetoscopio = 0;
            }
            EstetoscopioF.GetComponent<SpriteRenderer>().sprite = nm.estetoscopioArray[currentOptionEstetoscopio];
            nm.estetoscopio = currentOptionEstetoscopio;
        }
    }

    public void PrevEstetoscopio()
    {
        GameObject Estetoscopio = GameObject.Find("Estetoscopio");
        GameObject EstetoscopioF = GameObject.Find("EstetoscopioF");


        if (nm.sexo == 0)
        {
            currentOptionEstetoscopio--;
            if (currentOptionEstetoscopio < 0)
            {
                currentOptionEstetoscopio = 1;
            }
            Estetoscopio.GetComponent<SpriteRenderer>().sprite = nm.estetoscopioArray[currentOptionEstetoscopio];
            nm.estetoscopio = currentOptionEstetoscopio;
        }
        else
        {
            currentOptionEstetoscopio--;
            if (currentOptionEstetoscopio < 0)
            {
                currentOptionEstetoscopio = 1;
            }
            EstetoscopioF.GetComponent<SpriteRenderer>().sprite = nm.estetoscopioArray[currentOptionEstetoscopio];
            nm.estetoscopio = currentOptionEstetoscopio;
        }
    }

    public void NextMascara()
    {
        GameObject Mascara = GameObject.Find("Mascara");
        GameObject MascaraF = GameObject.Find("MascaraF");

        if (nm.sexo == 0)
        {
            currentOptionMascara++;
            if (currentOptionMascara >= nm.oclinArray.Length)
            {
                currentOptionMascara = 0;
            }
            Mascara.GetComponent<SpriteRenderer>().sprite = nm.mascaraArray[currentOptionMascara];
            nm.mascara = currentOptionMascara;
        }
        else
        {
            currentOptionMascara++;
            if (currentOptionMascara >= nm.oclinArray.Length)
            {
                currentOptionMascara = 0;
            }
            MascaraF.GetComponent<SpriteRenderer>().sprite = nm.mascaraArray[currentOptionMascara];
            nm.mascara = currentOptionMascara;
        }
    }

    public void PrevMascara()
    {
        GameObject Mascara = GameObject.Find("Mascara");
        GameObject MascaraF = GameObject.Find("MascaraF");


        if (nm.sexo == 0)
        {
            currentOptionMascara--;
            if (currentOptionMascara < 0)
            {
                currentOptionMascara = 1;
            }
            Mascara.GetComponent<SpriteRenderer>().sprite = nm.mascaraArray[currentOptionMascara];
            nm.mascara = currentOptionMascara;
        }
        else
        {
            currentOptionMascara--;
            if (currentOptionMascara < 0)
            {
                currentOptionMascara = 1;
            }
            MascaraF.GetComponent<SpriteRenderer>().sprite = nm.mascaraArray[currentOptionMascara];
            nm.mascara = currentOptionMascara;
        }
    }

}
