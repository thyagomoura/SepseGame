using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public Text timerText;

    public float timeLeft = 0.0f;

    private bool active = false;

    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        string cs = SceneManager.GetActiveScene().name;
        if (cs == "Customize Nurse" || cs == "MainMenu" || cs == "Transicao" || cs == "Pontuacao" || cs == "FeedbackCondutas" || cs == "FinalScene" || cs == "TimeUp" || GameObject.Find("BBGTutorial") != null)
        {
            active = false;
        }
        else
        {
            active = true;
        }

        if (active)
        {
            timeLeft += Time.deltaTime;
            float minutes = Mathf.FloorToInt(timeLeft / 60);
            float seconds = Mathf.FloorToInt(timeLeft % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        Debug.Log(active);
    }
}
