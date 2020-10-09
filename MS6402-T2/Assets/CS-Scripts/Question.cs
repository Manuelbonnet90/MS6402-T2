using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public int intQuestionNumber;
    public int intStoryNumber;
    public string[] stAnswers;
    public bool blCorrectAnswer = false;
    public Text txtAnswer;
    
    // Start is called before the first frame update
    void Start()
    {
        if (GM.Story1 == 0)
        {
            txtAnswer.text = stAnswers[0];
        }
        else if (GM.Story1 == 1)
        {
            txtAnswer.text = stAnswers[1];
        }
        else if (GM.Story1 == 2)
        {
            txtAnswer.text = stAnswers[2];
        }
        else if (GM.Story1 == 3)
        {
            txtAnswer.text = stAnswers[3];
        }
        else if (GM.Story1 == 4)
        {
            txtAnswer.text = stAnswers[4];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (blCorrectAnswer)
        {
            Destroy(gameObject);
        }
    }


    public void IncorrectAnswer()
    {
        GM.Timer -= 10;
    }

    public void CorrectAnswer()
    {
        blCorrectAnswer = true;
    }





}
