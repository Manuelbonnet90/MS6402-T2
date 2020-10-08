using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GM.Story1 = GenerateStory1();
        GM.Story2 = GenerateStory2();
        GM.Story3 = GenerateStory3();
    }

    //Story 1 is a multiple choice question so requires at least three options preferbly 5
    private int GenerateStory1()
    {
        return Random.Range(0, 4);
    }


    //Story 2 is a true (1) or false (0) question
    private int GenerateStory2()
    {
        return Random.Range(0, 4);
    }

    //Story 3 is a user input question where they must enter the correct word to progress. 3 or more possible words.
    private string GenerateStory3()
    {
        int selection = Random.Range(0, 4);
        switch (selection)
        {
            case 0: return "0";
            case 1: return "1";
            case 2: return "2";
            case 3: return "3";
            case 4: return "4";
        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
