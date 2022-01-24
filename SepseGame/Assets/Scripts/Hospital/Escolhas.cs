using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escolhas : MonoBehaviour
{
    Animation anim;
    bool isMIn = false;
    bool isEFIn = false;
    bool isEIn = false;

    public void monitorizar()
    {
        if (isPlaying(GameObject.Find("PanelMonitorizar").GetComponent<Animator>(), "In") || isPlaying(GameObject.Find("PanelMonitorizar").GetComponent<Animator>(), "Out"))
        {

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
    }
}
