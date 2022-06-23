using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationHandler : MonoBehaviour
{
    public void goNext()
    {
        SceneManager.LoadScene("Dialogo");
    }
}
