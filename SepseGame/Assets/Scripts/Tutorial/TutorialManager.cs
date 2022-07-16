using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public Sprite[] tutorialSprites = new Sprite[5];
    public Image atualSprite;
    public Button btnNext, btnBack, btnMainMenu;
    public TextMeshProUGUI tutorialText, pageCountText;
    int currentPage = 1;
    public Slider slider;
    public Estetica pack;
    public GameObject BBG, Box, TopTitle, Exit;

    [System.Obsolete]
    private void Start()
    {
        atualSprite.sprite = tutorialSprites[0];
        slider.value = currentPage;
        pageCountText.text = $"{tutorialText.pageToDisplay} / 5";
        //Debug.Log($"Paginas: {tutorialText.textInfo.pageCount}, atual: {currentPage}" );
    }

    public void NextPage()
    {
        int totalpages = tutorialText.textInfo.pageCount;

        if (currentPage < totalpages)
        {
            currentPage++;
            tutorialText.pageToDisplay++;
            pageCountText.text = $"{tutorialText.pageToDisplay} / {tutorialText.textInfo.pageCount}";
            atualSprite.sprite = tutorialSprites[currentPage - 1];
            slider.value = currentPage;
        }
        //Debug.Log($"Paginas: {tutorialText.textInfo.pageCount}, atual: {currentPage}");
    }
    public void PreviousPage()
    {
        int totalpages = tutorialText.textInfo.pageCount;

        if (currentPage > 1)
        {
            currentPage--;
            tutorialText.pageToDisplay--;
            pageCountText.text = $"{tutorialText.pageToDisplay} / {tutorialText.textInfo.pageCount}";
            atualSprite.sprite = tutorialSprites[currentPage - 1];
            slider.value = currentPage;
        }
        //Debug.Log($"Paginas: {tutorialText.textInfo.pageCount}, atual: {currentPage}");
    }

    public void ExitTutorial()
    {
        BBG.SetActive(false);
        Box.SetActive(false);
        TopTitle.SetActive(false);
        Exit.SetActive(false);
    }

    public void EnterTutorial()
    {
        GameObject.Find("Tutorial").SetActive(true);
        BBG.SetActive(true);
        Box.SetActive(true);
        TopTitle.SetActive(true);
        Exit.SetActive(true);
        Debug.Log("kjbsdlkjhfg");
    }
}
