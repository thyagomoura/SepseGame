using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public Text timerText;

    float timeLeft = 1200.0f;

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
        if (cs == "Customize Nurse" || cs == "MainMenu" || cs == "Transicao" || cs == "Pontuacao" || cs == "FeedbackCondutas")
        {
            active = false;
        }
        else
        {
            active = true;
        }

        if (active)
        {
            timeLeft -= Time.deltaTime;
            float minutes = Mathf.FloorToInt(timeLeft / 60);
            float seconds = Mathf.FloorToInt(timeLeft % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if(timeLeft <= 0.0f)
        {
            SceneManager.LoadScene("TimeUp");
            Destroy(gameObject);
        }
    }
}
