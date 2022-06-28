using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class InicialAnimManager : MonoBehaviour
{
    public GameObject contButton, anim1, anim2, txt1, txt2;

    int control = 0;

    public void changeContinuarStatus()
    {
        if (contButton.GetComponent<Button>().interactable == false)
        {
            contButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            contButton.GetComponent<Button>().interactable = false;
        }
    }

    public void continueAnimation()
    {
        if (control == 0)
        {
            txt1.SetActive(false);
            anim2.GetComponent<PlayableDirector>().Play();
            control = 1;
        }
        else
        {
            anim2.GetComponent<PlayableDirector>().Resume();
        }
    }

    public void pauseAnim2()
    {
        anim2.GetComponent<PlayableDirector>().Pause();
    }

    public void skipAnim()
    {
        anim1.GetComponent<PlayableDirector>().Stop();
        anim2.GetComponent<PlayableDirector>().initialTime = 22;
        anim2.GetComponent<PlayableDirector>().Play();
        txt1.SetActive(false);
        txt2.SetActive(false);
    }
}
