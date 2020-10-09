using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    #region Singleton
    static GM mSingleton = null;

    public GM Singleton
    {
        get
        {
            return mSingleton;
        }
    }


    private void Awake()
    {
        if (mSingleton == null)
        {
            mSingleton = this;

        }
        else if (mSingleton != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    #region Stories

    #region Story1
    string currentStory1Answer1 = "Machete";
    public static string Story1Answer1
    {
        get
        {
            return mSingleton.currentStory1Answer1;
        }
        set
        {
            mSingleton.currentStory1Answer1 = value;
        }
    }

    string currentStory1Answer2 = "true";
    public static string Story1Answer2
    {
        get
        {
            return mSingleton.currentStory1Answer2;
        }
        set
        {
            mSingleton.currentStory1Answer2 = value;
        }
    }

    string currentStory1Answer3 = "Cameron";
    public static string Story1Answer3
    {
        get
        {
            return mSingleton.currentStory1Answer3;
        }
        set
        {
            mSingleton.currentStory1Answer3 = value;
        }
    }

    #endregion

    #region Story2

    string currentStory2 = "Yes";
    public static string Story2Answer1
    {
        get
        {
            return mSingleton.currentStory2;
        }
        set
        {
            mSingleton.currentStory2 = value;
        }
    }
    string currentStory2Answer2 = "Jessica";
    public static string Story2Answer2
    {
        get
        {
            return mSingleton.currentStory2Answer2;
        }
        set
        {
            mSingleton.currentStory2Answer2 = value;
        }
    }

    string currentStory2Answer3 = "Squidward3965";
    public static string Story2Answer3
    {
        get
        {
            return mSingleton.currentStory2Answer3;
        }
        set
        {
            mSingleton.currentStory2Answer3 = value;
        }
    }

    #endregion

    #region Story3

    string currentStory3 = "default";
    public static string Story3Answer1
    {
        get
        {
            return mSingleton.currentStory3;
        }
        set
        {
            mSingleton.currentStory3 = value;
        }
    }

    int currentStory3Answer2 = 1;
    public static int Story3Answer2
    {
        get
        {
            return mSingleton.currentStory3Answer2;
        }
        set
        {
            mSingleton.currentStory3Answer2 = value;
        }
    }

    int currentStory3Answer3 = 1;
    public static int Story3Answer3
    {
        get
        {
            return mSingleton.currentStory3Answer3;
        }
        set
        {
            mSingleton.currentStory3Answer3 = value;
        }
    }

    #endregion

    #endregion

    #region Time



    float currentTime = 30.0f;
    public static float Timer
    {
        get
        {
            return mSingleton.currentTime;
        }
        set
        {
            mSingleton.currentTime = value;
            if (mSingleton.currentTime < 0)
                mSingleton.currentTime = 0;
        }
    }

    public static void AddTime(float time)
    {
        mSingleton.currentTime += time;
    }

    private static void CountTime()
    {
        if (mSingleton.currentTime >= 0.0f)
        {
            mSingleton.currentTime -= Time.deltaTime;
        }
        else
        {
            mSingleton.gameOver = true;
        }
            


    }

    #endregion

    private bool gameOver = false;
    //public GameObject objectPC;

    public static bool GameOver
    {
        get
        {
            return mSingleton.gameOver;
        }
        set
        {
            mSingleton.gameOver = value;
            
        }
    }

    private float victoryTime = 0.0f;
    private float victoryWaitTime = 5.0f;
    private bool startVictoryTime = false;
    private bool gameVictory = false;
    public static bool Victory
    {
        get
        {
            return mSingleton.gameVictory;
        }
        set
        {
            mSingleton.gameVictory = value;

        }
    }


    public static void StartTime()
    {
        mSingleton.startTime = true;
    }

    private float gameOverTime = 0.0f;
    private float gameOverWaitTime = 5.0f;
    private bool startTime = false;
    private bool startGameOverTime = false;

    //public GameObject controlsUI;
    private void Start()
    {
        //controlsUI.SetActive(true);
        //Destroy(controlsUI, 10.0f);
        
    }

    private void Update()
    {
        if (startTime)
        {
            CountTime();
            //Timer = -1 * Time.deltaTime;
        }

        if (gameOver)
        {
            
            if (!startGameOverTime)
            {
                gameOverTime = Time.time + gameOverWaitTime;
            }
            
            startGameOverTime = true;
            
            if (startGameOverTime)
            {
                if (Time.time > gameOverTime)
                {
                    //GM.ResetVariables();
                    Cursor.lockState = CursorLockMode.None;
                    SceneManager.LoadScene("Menu");
                }
            }

        }

        if (gameVictory)
        {

            if (!startVictoryTime)
            {
                victoryTime = Time.time + victoryWaitTime;
            }

            startVictoryTime = true;

            if (startVictoryTime)
            {
                if (Time.time > victoryTime)
                {
                    //GM.ResetVariables();
                    Cursor.lockState = CursorLockMode.None;
                    SceneManager.LoadScene("Menu");
                }
            }

        }



    }

}
