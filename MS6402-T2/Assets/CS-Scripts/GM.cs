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


    }

    #endregion

    public static void StartTime()
    {
        mSingleton.startTime = true;
    }

    private bool startTime = false;

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

    }

}
