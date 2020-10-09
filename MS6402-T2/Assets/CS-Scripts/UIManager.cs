using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text textTime;
    public GameObject goGameOver;
    public GameObject goVictory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textTime != null)
        {
            textTime.text = "Time: " + Mathf.RoundToInt(GM.Timer);
        }
        if(goGameOver!=null && GM.GameOver)
        {
            goGameOver.SetActive(true);
        }

    }

    void DisplayWindow()
    {

    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
