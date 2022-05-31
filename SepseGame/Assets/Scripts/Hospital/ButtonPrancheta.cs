using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPrancheta : MonoBehaviour
{
    public Animator anim;

    private void OnMouseEnter()
    {
        anim.Play("slide_in");
    }

    private void OnMouseExit()
    {
        anim.Play("slide_out");
    }
}
