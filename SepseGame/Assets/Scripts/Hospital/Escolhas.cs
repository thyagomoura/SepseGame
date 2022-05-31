using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escolhas : MonoBehaviour
{
    Animation anim;
    public bool isMIn = false;
    public bool isEFIn = false;
    public bool isEIn = false;
    public bool isPIn = false;

    public void monitorizar()
    {
        if (isPlaying(GameObject.Find("PanelMonitorizar").GetComponent<Animator>(), "In") || isPlaying(GameObject.Find("PanelMonitorizar").GetComponent<Animator>(), "Out"))
        {
            return;
        }
        else if (!isMIn)
        {
            GameObject.Find("PanelMonitorizar").GetComponent<Animator>().Play("In");
            isMIn = true;
            disable(0);
            return;
        }
        else
        {
            GameObject.Find("PanelMonitorizar").GetComponent<Animator>().Play("Out");
            isMIn = false;
            return;
        }
    }

    public void examesFiscos()
    {
        if (isPlaying(GameObject.Find("PanelExamesFisicos").GetComponent<Animator>(), "InExamesFisicos") || isPlaying(GameObject.Find("PanelMonitorizar").GetComponent<Animator>(), "OutExamesFisicos"))
        {
            return;
        }
        else if (!isEFIn)
        {
            GameObject.Find("PanelExamesFisicos").GetComponent<Animator>().Play("InExamesFisicos");
            isEFIn = true;
            disable(1);
            return;
        }
        else
        {
            GameObject.Find("PanelExamesFisicos").GetComponent<Animator>().Play("OutExamesFisicos");
            isEFIn = false;
            return;
        }
    }

    public void exames()
    {
        if (isPlaying(GameObject.Find("PanelExames").GetComponent<Animator>(), "InExames") || isPlaying(GameObject.Find("PanelExames").GetComponent<Animator>(), "OutExames"))
        {
            return;
        }
        else if (!isEIn)
        {
            GameObject.Find("PanelExames").GetComponent<Animator>().Play("InExames");
            isEIn = true;
            disable(2);
            return;
        }
        else
        {
            GameObject.Find("PanelExames").GetComponent<Animator>().Play("OutExames");
            isEIn = false;
            return;
        }
    }

    public void prancheta()
    {
        if (isPlaying(GameObject.Find("Content").GetComponent<Animator>(), "slide_in_content") || isPlaying(GameObject.Find("Content").GetComponent<Animator>(), "slide_out_content"))
        {
            return;
        }
        else if (!isPIn)
        {
            GameObject.Find("Content").GetComponent<Animator>().Play("slide_in_content");
            isPIn = true;
            disable(3);
            return;
        }
        else
        {
            GameObject.Find("Content").GetComponent<Animator>().Play("slide_out_content");
            isPIn = false;
            return;
        }
    }

    bool isPlaying(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }

    private void disable(int exception)
    {
        if (isMIn && exception != 0)
        {
            GameObject.Find("PanelMonitorizar").GetComponent<Animator>().Play("Out");
            isMIn = false;
        }
        if(isEFIn && exception != 1)
        {
            GameObject.Find("PanelExamesFisicos").GetComponent<Animator>().Play("OutExamesFisicos");
            isEFIn = false;
        }
        if (isEIn && exception != 2)
        {
            GameObject.Find("PanelExames").GetComponent<Animator>().Play("OutExames");
            isEIn = false;
        }
        if (isPIn && exception != 3)
        {
            GameObject.Find("Content").GetComponent<Animator>().Play("slide_out_content");
            isPIn = false;
        }
    }
}
