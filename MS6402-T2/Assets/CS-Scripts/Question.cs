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
    public Text[] txtIncorrect;
    public GameObject Panel;
    
    // Start is called before the first frame update
    void Start()
    {
        //if (GM.Story1 == 0)
        //{
        //    txtAnswer.text = stAnswers[0];
        //}
        //else if (GM.Story1 == 1)
        //{
        //    txtAnswer.text = stAnswers[1];
        //}
        //else if (GM.Story1 == 2)
        //{
        //    txtAnswer.text = stAnswers[2];
        //}
        //else if (GM.Story1 == 3)
        //{
        //    txtAnswer.text = stAnswers[3];
        //}
        //else if (GM.Story1 == 4)
        //{
        //    txtAnswer.text = stAnswers[4];
        //}

        if (intStoryNumber == 1)
        {
            if (intQuestionNumber == 1)
            {
                txtAnswer.text = GM.Story1Answer1.ToString();
            }
            else if (intQuestionNumber == 2)
            {
                txtAnswer.text = GM.Story1Answer2.ToString();

            }
            else if (intQuestionNumber == 3)
            {
                txtAnswer.text = GM.Story1Answer3.ToString();
            }
        }
        else if(intStoryNumber == 2)
        {
            if (intQuestionNumber == 1)
            {
                txtAnswer.text = GM.Story2Answer1.ToString();
            }
            else if (intQuestionNumber == 2)
            {
                txtAnswer.text = GM.Story2Answer2.ToString();

            }
            else if (intQuestionNumber == 3)
            {
                txtAnswer.text = GM.Story2Answer3.ToString();
            }
        }
        else if (intStoryNumber == 3)
        {
            if (intQuestionNumber == 1)
            {
                txtAnswer.text = GM.Story3Answer1.ToString();
            }
            else if (intQuestionNumber == 2)
            {
                txtAnswer.text = GM.Story3Answer2.ToString();

            }
            else if (intQuestionNumber == 3)
            {
                txtAnswer.text = GM.Story3Answer3.ToString();
            }
        }

        for (int i=0; i< txtIncorrect.Length; i++)
        {
            txtIncorrect[i].text = stAnswers[Random.Range(0, stAnswers.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (blCorrectAnswer)
        {
            Destroy(gameObject);
            Destroy(Panel);
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
