using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    #region Story

    int currentStory1 = 1;
    public static int Story1
    {
        get
        {
            return mSingleton.currentStory1;
        }
        set
        {
            mSingleton.currentStory1 = value;
        }
    }

    int currentStory2 = 1;
    public static int Story2
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

    string currentStory3 = "default";
    public static string Story3
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
            mSingleton.gameOver = true;


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


    public static void StartTime()
    {
        mSingleton.startTime = true;
    }


    private float gameOverTime = 0.0f;
    private float gameOverWaitTime = 5.0f;
    private bool startTime = false;

    //public GameObject controlsUI;
    private void Start()
    {
        //controlsUI.SetActive(true);
        //Destroy(controlsUI, 10.0f);
    }

    private void Update()
    {


    }

    public static void ResetVariables()
    {


    }

}
