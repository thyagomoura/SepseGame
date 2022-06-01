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
        GameObject PeleF = GameObject.Find("PeleF");
        corDaPele = EsteticaNurse.corDaPele;
        PeleF.GetComponent<SpriteRenderer>().sprite = peleArrayF[corDaPele];
    }

}
